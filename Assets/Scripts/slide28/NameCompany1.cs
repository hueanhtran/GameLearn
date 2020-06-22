using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameCompany1 : MonoBehaviour
{
    public static string tip1 = "";
    Text str;
    void Start() {
        str = GetComponent<Text>();
    }
    void Update() {
        str.text =  tip1;
    }
}
