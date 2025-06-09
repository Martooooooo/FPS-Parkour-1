using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hurtingObject : MonoBehaviour
{
    public int damagePoints;
    public HealthManager healthManager;
    // Start is called before the first frame update
    void Start()
    {
        healthManager = FindObjectOfType<HealthManager>();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //restar damage Points a la salud del player
            healthManager.UpdateHealth(-damagePoints);
        }
    }
}
