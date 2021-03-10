using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : PowerUp
{
    public float slow;
    protected override void Interact(ShipMotor shipMotor)
    {
        foreach (var asteroid in GameObject.FindObjectsOfType<Asteroid>())
        {
            asteroid.StopForXTime(slow); 
        }
        Destroy(gameObject);
    }
}
