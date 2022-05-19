using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerNavMesh : MonoBehaviour
{
    [Header("Debug only")]
    public Transform destination;

    private NavMeshAgent _navMeshAgent;
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        HandleMovement();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Coin"))
        {
            AudioController ac = GameManager.instance.audioController;
            int i = Random.Range(0, 3);

            ac.ToqueSFX(ac.coinSounds[i]);
        }
    }

    private void HandleMovement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            animator.SetBool("IsMoving", true);

            if (Physics.Raycast(ray, out hit))
            {
                _navMeshAgent.SetDestination(hit.point);
            }

        }
        else
        {
            animator.SetBool("IsMoving", false);
            animator.SetBool("Idle", true);
        }
    }
}
