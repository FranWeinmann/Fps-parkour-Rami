using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;
    public UIManager uimanager;

    void Start()
    {
        uimanager = FindObjectOfType<UIManager>(); // FindFirstObjectByType para la 2022
    }

    public bool UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            // Impedir la compra
            Debug.Log("Dinero insuficiente");
            return false;
        }
        else
        {
            money += amount;
            uimanager.UpdateMoneyText(money.ToString());
            return true;
        }
    }
}
