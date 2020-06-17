using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubControllerTipAdvisor : MonoBehaviour
{
    
    public GameObject Tip1,Tip2,ButtonNext,ButtonPre;

    public void Next() {
        Tip1.SetActive(false);
        ButtonNext.SetActive(false);
        Tip2.SetActive(true);
        ButtonPre.SetActive(true);
    }
    public void Pre() {
        Tip1.SetActive(true);
        ButtonNext.SetActive(true);
        Tip2.SetActive(false);
        ButtonPre.SetActive(false);
    }
}
