using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyModel : MonoBehaviour
{
    public static int scoreValue = 15000;
    Text score;
    void Start() {
        score = GetComponent<Text>();
    }
    void Update() {
        score.text =  scoreValue.ToString();
    }
}
