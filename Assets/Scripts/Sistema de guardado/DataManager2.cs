using UnityEngine;

public class DataManager2 : MonoBehaviour
{
    public string playerName;
    public Vector3 playerPosition;
    public float playerHealth;
    public int playerExp;


    void Update()
    {
        //Al pulsar G llama a la funcion de SaveData y asi se guarda la lista
        if(Input.GetKeyDown(KeyCode.G))
        {
            SaveData();
        }

        //Al pular C carga la partida (la informacion del LoadData)
        if(Input.GetKeyDown(KeyCode.C))
        {
            LoadData();
        }
    }

        void SaveData()
    {
        Stats.userStats.playerName = playerName;
        Stats.userStats.playerPosition = playerPosition;
        Stats.userStats.playerHealth = playerHealth;
        Stats.userStats.playerExp = playerExp;

        SaveDataSystem.Save();
    }

    void LoadData()
    {
        SaveDataSystem.Load();

        playerName = Stats.userStats.playerName;
        playerPosition = Stats.userStats.playerPosition;
        playerHealth = Stats.userStats.playerHealth;
        playerExp = Stats.userStats.playerExp;
    }
}
