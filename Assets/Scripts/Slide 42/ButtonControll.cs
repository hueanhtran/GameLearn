using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControll : MonoBehaviour
{
    public GameObject tick1,tick2,tick3,Activetick1,Activetick2,Activetick3;
    private bool check = false;

    public void ClickTick1() {
        tick1.SetActive(false);
        Activetick1.SetActive(true);
    }
    public void ActiveClickTick1() {
        tick1.SetActive(true);
        Activetick1.SetActive(false);
    }
    public void ClickTick2() {
        tick2.SetActive(false);
        Activetick2.SetActive(true);
    }
    public void ActiveClickTick2() {
        tick2.SetActive(true);
        Activetick2.SetActive(false);
    }
    public void ClickTick3() {
        tick3.SetActive(false);
        Activetick3.SetActive(true);
    }
    public void ActiveClickTick3() {
        tick3.SetActive(true);
        Activetick3.SetActive(false);
    }
    
}
