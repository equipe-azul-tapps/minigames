using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] obs;
    private int rnd;
    void Start()
    {
        rnd = Random.Range(0, 3);
        Instantiate(obs[rnd]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
