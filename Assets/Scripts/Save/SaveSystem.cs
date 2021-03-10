using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;


//ESTO CREA EL ARCHIVO DE GUARDADO

public static class SaveSystem
{
    public static void SaveGame (SaveManager game)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.txt";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(game);

        formatter.Serialize(stream, data);
        stream.Close();    
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/save.txt";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;
        }
        else
        {
            return null;
        }
    }
}
