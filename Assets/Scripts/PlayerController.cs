using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _rigidBody;
    public float movementSpeed = 10;
    public int direction;

    void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Teleport();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            direction = 1;
        }

        else if(Input.GetKeyUp(KeyCode.W))
        {
            direction = 0;
        }
    }
    void FixedUpdate()
    {
        _rigidBody.linearVelocity = Vector3.forward * movementSpeed * direction;
    }

    //Funcion para guardar la informacion de la posicion
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("CheckPoint"))
        {
            PlayerPrefs.SetFloat("XPosition", transform.position.x);
            PlayerPrefs.SetFloat("YPosition", transform.position.y);
            PlayerPrefs.SetFloat("ZPosition", transform.position.z);
        }
    }

    //Funcion para coger la informacion guardada y cargarla
    void Teleport()
    {
        Vector3 teleportPosition;
        teleportPosition.x = PlayerPrefs.GetFloat("XPosition");
        teleportPosition.y = PlayerPrefs.GetFloat("YPosition");
        teleportPosition.z = PlayerPrefs.GetFloat("ZPosition");

        transform.position = teleportPosition;
    }
}
