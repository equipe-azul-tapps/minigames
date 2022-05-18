using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : Collectible
{
    public override void Collect()
    {
        Debug.Log("Acelerou");
        GameManager.instance.playerMovement.speed += 10f;
    }

}