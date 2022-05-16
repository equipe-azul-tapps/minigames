using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obsPrefab;
    public Transform borderLeft;
    public Transform borderRight;
    public Transform spawnMan;
    private float rnd;
    void Start()
    {
        rnd = Random.Range(1f, 3f);
        InvokeRepeating("SpawnBox", 2, rnd);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void SpawnBox()
    {
        int z = (int)spawnMan.position.z;
        int x = (int)Random.Range(borderLeft.position.x + 1, borderRight.position.x - 1);
        Instantiate(obsPrefab, new Vector3(x, 0, z), Quaternion.identity);

       
    }
}
