using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDeColisiones : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Contacto con " + collision.gameObject.name);
        Destroy(collision.gameObject);
    }
}

