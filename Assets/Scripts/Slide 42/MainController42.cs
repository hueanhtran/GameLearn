using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController42 : MonoBehaviour
{
    public GameObject slide42, slide43, slide44;
    public void ClickXBaiHoc()
    {
        slide42.SetActive(false);
        if (slide43 != null)
        {
            bool isActive2 = slide43.activeSelf;
            slide43.SetActive(true);
        }
    }
    public void ClickXBaiHoc()
    {
        slide43.SetActive(false);
        if (slide44 != null)
        {
            bool isActive2 = slide44.activeSelf;
            slide44.SetActive(true);
        }
    }

}
