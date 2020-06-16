using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPopup : MonoBehaviour
{
     public GameObject CanvasPopup, CanvasFeedback;
     
     public void NextPopupFeedback() {
         CanvasPopup.SetActive(false);
         if (CanvasFeedback != null) {
             CanvasFeedback.SetActive(true);
         }
     }
}
