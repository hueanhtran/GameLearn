using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverButtonT : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject iconchuTButtonHover;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        iconchuTButtonHover.SetActive(true);
    }

    // Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        iconchuTButtonHover.SetActive(false);
    }
}