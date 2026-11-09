using UnityEngine;

public static class PlayerData
{
    //Campos informacion del personaje
    public static int vitalidad;
    public static int fuerza;
    public static int destreza;
    public static int inteligencia;
    public static float experiencia;

    public static string nombreUsuario;

    public static Vector3 lastPosition;

    
    //Funcion crear lista de informacion del personaje
    public static void Save()
    {
        PlayerPrefs.SetString("NombreUsuario", nombreUsuario);
        PlayerPrefs.SetInt("VitalidadPersonaje", vitalidad);
        PlayerPrefs.SetInt("FuerzaPersonaje", fuerza);
        PlayerPrefs.SetInt("DestrezaPersonaje", destreza);
        PlayerPrefs.SetInt("InteligenciaPersonaje", inteligencia);
        PlayerPrefs.SetFloat("ExperienciaPersonaje", experiencia);
    }

    //Funcion para recuperar (cargar) la informacion de la funcion SaveData
    public static void Load()
    {
        nombreUsuario = PlayerPrefs.GetString("NombreUsuario", "Sin Nombre");
        vitalidad = PlayerPrefs.GetInt("VitalidadPersonaje", 1);
        fuerza = PlayerPrefs.GetInt("FuerzaPersonaje", 1);
        destreza = PlayerPrefs.GetInt("DestrezaPersonaje", 1);
        inteligencia = PlayerPrefs.GetInt("InteligenciaPersonaje", 1);
        experiencia = PlayerPrefs.GetFloat("ExperienciaPersonaje", 0.5f);
    }
}
