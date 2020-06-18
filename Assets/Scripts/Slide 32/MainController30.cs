using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainController30 : MonoBehaviour
{
    public GameObject slide18, slide20, slide21;
    public void next_l1()
    {
        slide18.SetActive(false);
        if (slide20 != null)
        {
            bool isActive3 = slide18.activeSelf;
            slide20.SetActive(true);
        }
    }
    public void back_l1()
    {
        slide20.SetActive(false);
        if (slide18 != null)
        {
            bool isActive3 = slide20.activeSelf;
            slide18.SetActive(true);
        }
    }
    public void next_l2()
    {
        slide20.SetActive(false);
        if (slide21 != null)
        {
            bool isActive3 = slide21.activeSelf;
            slide21.SetActive(true);
        }
    }
    public void back_l2()
    {
        slide21.SetActive(false);
        if (slide20 != null)
        {
            bool isActive3 = slide20.activeSelf;
            slide20.SetActive(true);
        }
    }
}
