using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    //DATOS
    public int health;
 

    //SAVE
    public void SavePlayer()
    {
        SaveSystem.SaveGame(this);
    }

    //LOAD
    public void LoadPlayer()
    {
        //ACA SE LE PASA TODO LO QUE TIENE QUE LOADEAR

       PlayerData data = SaveSystem.LoadPlayer();

       health = data.health;

    }
}
