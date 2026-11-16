using UnityEngine;
using System.IO;

public static class SaveDataSystem
{
    //Ruta para saber dónde se va a guardar. Saber la ruta de guardado.
    static string savePath = Application.persistentDataPath + "/SaveFile.save";

    //Coge el script de UserStats y hace que sea un json.
    public static void Save()
    {
        string json = JsonUtility.ToJson(Stats.userStats, true);
        File.WriteAllText(savePath, json);
        Debug.Log("Guardado en: + savePath");
    }

    public static void Load()
    {
        if(File.Exists(savePath))
        {
            string json = File.ReadAllText(savePath);
            Stats.userStats = JsonUtility.FromJson<UserStats>(json);
            Debug.Log("Datos cargados");
        }
        else
        {
            Debug.Log("No hay datos guardados");
        }
    }
}
