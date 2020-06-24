using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class HoverButtonDoc : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject IconToGiayButtonHover;

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        IconToGiayButtonHover.SetActive(true);
    }

    // Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        IconToGiayButtonHover.SetActive(false);
    }
}
