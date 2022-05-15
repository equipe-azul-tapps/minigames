using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Collectible
{
    public override void Collect()
    {
        Debug.Log("Coletou");
        GameManager.instance.IncreaseCoins(1);
    }

}
