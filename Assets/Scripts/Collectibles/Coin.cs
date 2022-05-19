using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectible
{
    private float rotateSpeed = 0.5f;

    private void Update()
    {
        transform.Rotate(transform.right, 360 * rotateSpeed * Time.deltaTime);
    }
    public override void Collect()
    {
        GameManager.instance.IncreaseCoins(1);
    }

}
