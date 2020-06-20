using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverToolTip : MonoBehaviour, IPointerEnterHandler,IPointerExitHandler {
public GameObject CanvasHover;

public void OnPointerEnter(PointerEventData pointerEventData){
    CanvasHover.SetActive(true);
}

// Detect when Cursor leaves the GameObject
public void OnPointerExit(PointerEventData pointerEventData) {
        CanvasHover.SetActive(false);
    }
}