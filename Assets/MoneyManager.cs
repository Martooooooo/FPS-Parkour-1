using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : MonoBehaviour
{
    // Start is called before the first frame update
    public float money;
    public TextMeshProUGUI txtDinero;

    private void Start()
    {
        txtDinero.text = "Dinero actual: $" + money;
    }
    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            //Debug.Log("No te alcanza");
            txtDinero.text = "No te alcanza";
            return false;

        } else
        {
            money += amount;
            txtDinero.text = "Dinero actual: $" + money;
            return true;
        }
        
    }
}
