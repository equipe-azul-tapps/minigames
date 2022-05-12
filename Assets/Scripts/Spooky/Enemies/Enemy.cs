using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Paths")]
    public bool isCyclic = false;
    public List<Transform> paths;

    private NavMeshAgent _agent;
    [SerializeField]
    private int _pathCount = 0;
    private bool _isPlayerMovingForward = true;

    private void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        _agent.destination = paths[_pathCount].position;
    }

    private void Update()
    {
        if (Vector3.Distance(_agent.transform.position, paths[_pathCount].position) < .5f)
        {
            _agent.destination = isCyclic ?
                NextCyclicPosition() :
                NextNonCyclicPosition();
        }
    }

    /// <summary>
    /// Movimento não cíclico, finalizando seu movimento no fim do caminho e retornando por ele
    /// </summary>
    private Vector3 NextNonCyclicPosition()
    {
        if (_isPlayerMovingForward)
        {
            _pathCount++;
            if (_pathCount >= paths.Count)
            {
                _isPlayerMovingForward = false;
                _pathCount--;
            }
        }
        else
        {
            _pathCount--;
            if (_pathCount < 0)
            {
                _isPlayerMovingForward = true;
                _pathCount++;
            }

        }

        return paths[_pathCount].position;
    }

    /// <summary>
    /// Movimento cíclico, finalizando sua trajetória onde começou
    /// </summary>
    private Vector3 NextCyclicPosition()
    {
        _pathCount++;

        if (_pathCount >= paths.Count) _pathCount = 0;

        return paths[_pathCount].position;
    }
}
