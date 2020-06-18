using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyModel2 : MonoBehaviour
{
    public static int moneyValue = 15120;
    Text money;
    void Start() {
        money = GetComponent<Text>();
    }
    void Update() {
        money.text =  moneyValue.ToString();
    }
}
