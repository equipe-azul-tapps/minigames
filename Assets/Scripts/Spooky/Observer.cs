using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{

    public GameObject target;
    public bool inRange = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
            inRange = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.CompareTag("Player"))
            inRange = false;
    }

    private void Start()
    {
        target = GameManager.instance.player;
    }

    void Update()
    {
        if (inRange)
        {
            Ray ray = new Ray(transform.position, target.transform.position - transform.position);
            if (Physics.Raycast(ray, out RaycastHit hitInfo))
            {
                Debug.DrawRay(transform.position, target.transform.position - transform.position);
                if (hitInfo.transform.CompareTag("Player"))
                {
                    GameManager.instance.ShowLostScreen();
                }
            }
        }
    }
}
