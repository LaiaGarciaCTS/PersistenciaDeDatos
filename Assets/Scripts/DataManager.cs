using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour
{
    //Campos informacion del personaje
    public int vitalidad;
    public int fuerza;
    public int destreza;
    public int inteligencia;
    public float experiencia;

    public string nombreUsuario;

    //Funcion no destruir el objeto al cargar la escena
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    //Funcion cuando empieza el juego
    void Start()
    {
        //Cuando empiece el juego que se ejecute el LoadData (recuperar/cargar la lista del SaveData)
        LoadData();
    }

    //Funcion durante el juego
    void Update()
    {
        // Funcion cuando se pulse la tecla cambia de escena (tecla enter)
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }

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

/*
    //Funcion crear lista de informacion del personaje
    void SaveData()
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadPersonaje", vitalidad);
        PlayerPrefs.SetInt("FuerzaPersonaje", fuerza);
        PlayerPrefs.SetInt("DestrezaPersonaje", destreza);
        PlayerPrefs.SetInt("InteligenciaPersonaje", inteligencia);
        PlayerPrefs.SetFloat("ExperienciaPersonaje", experiencia);
    }

    //Funcion para recuperar (cargar) la informacion de la funcion SaveData
    void LoadData()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Sin Nombre");
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1);
        fuerza = PlayerPrefs.GetInt("FuerzaPersonaje", 1);
        destreza = PlayerPrefs.GetInt("DestrezaPersonaje", 1);
        inteligencia = PlayerPrefs.GetInt("InteligenciaPersonaje", 1);
        experiencia = PlayerPrefs.GetFloat("ExperienciaPersonaje", 0.5f);
    }
*/

    void SaveData()
    {
        /*
        PlayerData.NombreUsuario = nombreUsuario;
        PlayerData.VitalidadPersonaje = vitalidad;
        PlayerData.FuerzaPersonaje = fuerza;
        PlayerData.DestrezaPersonaje = destreza;
        PlayerData.InteligenciaPersonaje = inteligencia;
        PlayerData.ExperienciaPersonaje = experiencia;

        PlayerData.Save();
        */
    }

    void LoadData()
    {
    /*
        PlayerData.Load();

        nombreUsuario = PlayerData.NombreUsuario;
        vitalidad = PlayerData.VitalidadPersonaje;
        fuerza = PlayerData.FuerzaPersonaje;
        destreza = PlayerData.DestrezaPersonaje;
        inteligencia = PlayerData.InteligenciaPersonaje;
        experiencia = PlayerData.ExperienciaPersonaje;
        */
    }

}
