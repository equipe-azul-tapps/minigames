using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : Collectible
{
    public override void Collect()
    {
        Debug.Log("Mais tempo");
        GameManager.instance._currentTime += 10;
    }
}
