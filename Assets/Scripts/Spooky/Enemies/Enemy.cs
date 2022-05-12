using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    [Header("Paths")]
    public int threshold = 10;
    public List<Transform> paths;

    private NavMeshAgent _agent;
    private int _pathCount = 0;

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
        if (Vector3.Distance(_agent.transform.position, paths[_pathCount].position) < threshold)
        {
            _pathCount++;

            if (_pathCount >= paths.Count)
            {
                _pathCount = 0;
            }

            _agent.destination = paths[_pathCount].position;
        }
    }
}
