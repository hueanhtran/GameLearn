﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchPopup : MonoBehaviour
{
   public GameObject options, tutorial, muiten, popup_muctieu, MissionTong;
   public bool isCheckClickButtonHelp = false;

   public void ShowArrow() {
        popup_muctieu.SetActive(false);
        if (muiten != null) {
            muiten.SetActive(true);
	    }
        isCheckClickButtonHelp = true;
   }
    public void ShowTotorial(Text t) {
        t.color = Color.blue;
        tutorial.SetActive(false);
        if (tutorial != null)
        {   
            options.SetActive(false);
            tutorial.SetActive(true);
        }
    }
    public void HiddenOptions() {
        options.SetActive(false);
    }
    public void ShowPopupOptions() {
        if (isCheckClickButtonHelp) {
            muiten.SetActive(false);
            if (options != null)
            {
                bool isShow = options.activeSelf;
                options.SetActive(!isShow);
            } 
        }
	}
    public void NextSlide8(){
        tutorial.SetActive(false);
        if (MissionTong != null)
        {
            bool isActive3 = tutorial.activeSelf;
            MissionTong.SetActive(true);
        }
    }
}
