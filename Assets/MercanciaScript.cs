using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MercanciaScript : MonoBehaviour
{

    public int precio;
    public MoneyManager moneyManager;
    void Start()
    {
        moneyManager = FindObjectOfType<MoneyManager>();
    }
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Player")
        {
            
            if (moneyManager.UpdateMoney(-precio))
            {
                Destroy(gameObject);
            }
        }
    }
}
