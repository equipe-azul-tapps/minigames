using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    // Start is called before the first frame update
    private Vector3 startPos;
    private float repeatWidht;
    void Start()
    {
        startPos = transform.position;
        repeatWidht = GetComponent<BoxCollider>().size.z / 2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z < startPos.z / 2)
        {
            transform.position = startPos;
        }
    }
}
