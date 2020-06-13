using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwitchPopup : MonoBehaviour
{
   public GameObject options, tutorial, muiten, popup, popup2;

   public void ShowPopup() {
   	   popup.SetActive(false);
       if (popup2 != null) {
            bool isActive2 = popup2.activeSelf;
            popup2.SetActive(true);

	    }
   }
   public void ShowMuiTen() {
        popup2.SetActive(false);
        if (muiten != null) {
            bool isActive3 = popup2.activeSelf;
            muiten.SetActive(true);
	    }
   }
   public void ChangeColor(Text t){
        t.color = Color.blue;
        options.SetActive(false);
        if (tutorial != null) {
            bool isActive3 = tutorial.activeSelf;
            tutorial.SetActive(true);
	    }
    }
    public void HiddenOptions() {
        options.SetActive(false);
	}
    public void HiddenTotorial(int index) {
        tutorial.SetActive(false);
        SceneManager.LoadScene(index);
    }
}
