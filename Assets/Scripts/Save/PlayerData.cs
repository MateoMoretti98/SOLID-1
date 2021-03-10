using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//CONTENEDOR DE DATOS DE PLAYER

[System.Serializable]
public class PlayerData
{
    public int health;

    public PlayerData (SaveManager player)
    {
        health = player.health;

    }
}
