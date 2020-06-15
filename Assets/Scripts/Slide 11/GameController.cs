﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject Mission, muiten,iconchuT, iconToGiay, XMission, helpYourCustomer, character, clickhere;

    public void OpenPanel()
    {
        if (Mission != null)
        {
            bool isActive3 = iconchuT.activeSelf;
            Mission.SetActive(true);
        }
        
    }
    public void HiddenMuiTen()
    {
        muiten.SetActive(false);
       if (Mission != null)
        {
            bool isActive3 = muiten.activeSelf;
            Mission.SetActive(true);
        }

    }
    public void HiddenClickHere()
    {
        clickhere.SetActive(false);
        if (Mission != null)
        {
            bool isActive3 = clickhere.activeSelf;
            Mission.SetActive(true);
        }

    }
    public void ShowIconChuT()
    {
        Mission.SetActive(false);
            if (iconchuT != null)
            {
                bool isActive2 = iconchuT.activeSelf;
            iconchuT.SetActive(true);
        }
    }
    public void ShowIconToGiay()
    {
        Mission.SetActive(false);
        if (iconToGiay != null)
        {
            bool isActive2 = iconToGiay.activeSelf;
            iconToGiay.SetActive(true);
        }
    }
    public void CloseXMission()
    {
        iconchuT.SetActive(false);
        iconToGiay.SetActive(false);
        if (XMission != null)
        {
            bool isActive2 = XMission.activeSelf;
            XMission.SetActive(true);
        }
    }
    public void CloseXMissionTong()
    {
        Mission.SetActive(false);
        if (helpYourCustomer != null)
        {
            bool isActive3 = helpYourCustomer.activeSelf;
            helpYourCustomer.SetActive(true);
        }
    }
    public void ShowCharacter()
    {
        helpYourCustomer.SetActive(false);
        if (character != null)
        {
            bool isActive2 = character.activeSelf;
            character.SetActive(true);
        }
    }
    public void Talk(int index)
    {
        //muiten2.SetActive(false);
        SceneManager.LoadScene(index);
    }
}
   
