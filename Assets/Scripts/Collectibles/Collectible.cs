using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Collectible : MonoBehaviour
{
    public abstract void Collect();

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Collect();
            Destroy(gameObject);
        }
    }
}
