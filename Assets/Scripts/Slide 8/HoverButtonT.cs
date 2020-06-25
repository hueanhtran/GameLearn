using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverButtonT : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject CanvasIconHoverBtnT;
    int i = 0;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        // Debug.Log("Mouse enter" + i++);
        // if (CanvasIconHoverBtnT != null) {
        //     CanvasIconHoverBtnT.SetActive(true);
        // }
    }

    // Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        // Debug.Log("Mouse exit" + i++);
        // if (CanvasIconHoverBtnT != null) {
        //     CanvasIconHoverBtnT.SetActive(false);
        // }
    }
}