using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameCompany2 : MonoBehaviour
{
    public static string tip2 = "";
    Text str;
    void Start() {
        str = GetComponent<Text>();
    }
    void Update() {
        str.text =  tip2;
    }
}
