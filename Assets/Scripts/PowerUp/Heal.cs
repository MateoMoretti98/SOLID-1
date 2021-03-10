using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : PowerUp
{
    public int healAmount;
    protected override void Interact(ShipMotor shipMotor)
    {
        shipMotor.UpdateLife(healAmount);
        Destroy(gameObject);
    }

    
}
