using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController42 : MonoBehaviour
{
    public GameObject slide42, slide43, slide44, slide48, slide49, slide50,complete, slide53, slide54;
    public void ClickTiepTucBaiHoc()
    {
        slide42.SetActive(false);
        if (slide43 != null)
        {
            bool isActive2 = slide43.activeSelf;
            slide43.SetActive(true);
        }
    }
    public void ToiLaKhachHang()
    {
        slide43.SetActive(false);
        if (slide44 != null)
        {
            bool isActive2 = slide44.activeSelf;
            slide44.SetActive(true);
        }
    }
    public void NextTiepTuc_44()
    {
        slide44.SetActive(false);
        if (slide48 != null)
        {
            bool isActive2 = slide48.activeSelf;
            slide48.SetActive(true);
        }
    }
    public void DapAn1()
    {
        slide48.SetActive(false);
        if (slide49 != null)
        {
            bool isActive2 = slide49.activeSelf;
            slide49.SetActive(true);
        }
    }
    public void DapAn2()
    {
        slide48.SetActive(false);
        if (slide50 != null)
        {
            bool isActive2 = slide50.activeSelf;
            slide50.SetActive(true);
        }
    }
    public void ButtonBaiHoc()
    {
        slide49.SetActive(false);
        if (slide44 != null)
        {
            bool isActive2 = slide44.activeSelf;
            slide44.SetActive(true);
        }
    }
    public void ButtonTiepTucDung()
    {
        slide50.SetActive(false);
        if (complete != null)
        {
            bool isActive2 = complete.activeSelf;
            complete.SetActive(true);
        }
    }
    public void ButtonTiepTucslide52()
    {
        complete.SetActive(false);
        if (slide53 != null)
        {
            bool isActive2 = slide53.activeSelf;
            slide53.SetActive(true);
        }
    }
    public void ButtonTiepTucslide53()
    {
        slide53.SetActive(false);
        if (slide54 != null)
        {
            bool isActive2 = slide54.activeSelf;
            slide54.SetActive(true);
        }
    }
}
