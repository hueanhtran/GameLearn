using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameCompany3 : MonoBehaviour
{
    public static string tip3 = "";
    Text str;
    void Start() {
        str = GetComponent<Text>();
    }
    void Update() {
        str.text =  tip3;
    }
}
