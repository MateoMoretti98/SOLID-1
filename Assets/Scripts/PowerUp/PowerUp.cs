using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        ShipMotor shipMotor = other.gameObject.GetComponent<ShipMotor>();

        if (shipMotor != null)
        {
            Interact(shipMotor);
        }
    }

    protected abstract void Interact(ShipMotor shipMotor);
   
}
