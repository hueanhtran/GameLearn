using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextPopup : MonoBehaviour
{
     public GameObject CanvasPopup, CanvasFeedback,CanvasTipAdvisor,CanvasTutorial,CanvasTooltipPhone,CanvasMission;
    public bool isOpenPopUp = false;

     public void NextPopupFeedback() {
         CanvasPopup.SetActive(false);
         if (CanvasFeedback != null) {
             CanvasFeedback.SetActive(true);
         }
     }
     public void NextPopupTipAdvisor() {
         CanvasTutorial.SetActive(false);
         if (CanvasTipAdvisor != null) {
             CanvasTipAdvisor.SetActive(true);
         }
     }
     public void NextPopupTipPhone() {
         CanvasTipAdvisor.SetActive(false);
         if (CanvasTooltipPhone != null) {
             CanvasTooltipPhone.SetActive(true);
             isOpenPopUp = true;
         }
     }
     public void NextPopupMission() {
         CanvasTooltipPhone.SetActive(false);
         if (isOpenPopUp) {
            if (CanvasMission != null) {
                bool isCheck = CanvasMission.activeSelf;
                CanvasMission.SetActive(!isCheck);
            }
         }
     }
}
