using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubController : MonoBehaviour
{
    
    public GameObject tutorial_text1,tutorial_text2,ButtonNext,ButtonPre;

    public void Next() {
        tutorial_text1.SetActive(false);
        ButtonNext.SetActive(false);
        tutorial_text2.SetActive(true);
        ButtonPre.SetActive(true);
    }
    public void Pre() {
        tutorial_text1.SetActive(true);
        ButtonNext.SetActive(true);
        tutorial_text2.SetActive(false);
        ButtonPre.SetActive(false);
    }
}
