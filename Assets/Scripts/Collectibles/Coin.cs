using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectible
{
    //public void OnCollisionEnter(Collision collision)
    //{
    //    Destroy(gameObject);
    //    Collect();
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Collect();
            Destroy(gameObject);
            Debug.Log("Acelerou");
        }
    }
    public override void Collect()
    {
        Debug.Log("Coletou");
        GameManager.instance.IncreaseCoins(1);
    }
    
}
