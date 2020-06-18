using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeModel : MonoBehaviour
{
    public GameObject ButtonTiepTuc;
    Text time;
    float timeLeft = 59;
    void Start() {
        time = GetComponent<Text>();
    }
    void Update() {
        timeLeft -= Time.deltaTime;
        int iValue = (int)timeLeft;
        if (iValue > 0){
            time.text =  convertStringNumber(iValue);
        }
        if (iValue == 0) {
            ButtonTiepTuc.SetActive(true);
        }
    }
    public string convertStringNumber(int number) {
        string str = null;
        if (number < 10) {
            return str = '0' + number.ToString();
        } else {
            return str = number.ToString();
        }
    }
}
