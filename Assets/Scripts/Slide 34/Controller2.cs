using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controller2 : MonoBehaviour
{
    public GameObject QS1,QS2,QS3,slide22, slide35, slide23,slide24,slide25, slide27;
    public void iCan()
    {
        slide22.SetActive(false);
        if (slide23 != null)
        {
            bool isActive2 = slide23.activeSelf;
            slide23.SetActive(true);
        }
    }

    /* public void ClickHow()
    {
        StartCoroutine(Wait(0.5f));
    }
    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    */
    public void YouNeed()
    {
        /*SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("LOCK");
        Application.Quit();*/

        slide22.SetActive(false);
        if (slide24 != null)
        {
            bool isActive2 = slide24.activeSelf;
            slide24.SetActive(true);
        }
    }
    public void WhatDo()
    {
        slide22.SetActive(false);
        if (slide25 != null)
        {
            bool isActive2 = slide25.activeSelf;
            slide25.SetActive(true);
        }
    }
    public void ClickXbutton23()
    {
        slide23.SetActive(false);
        slide24.SetActive(false);
        slide25.SetActive(false);

        if (slide22 != null)
        {
            bool isActive3 = slide22.activeSelf;
            slide22.SetActive(true);
        }
    }
    public void buttonContinue()
    {
        slide22.SetActive(false);
        if (slide27!=null)
        {
            slide27.SetActive(true);
        }
    }
    public void NextScreen28(int index)
    {
        //muiten2.SetActive(false);
        SceneManager.LoadScene(index);
    }
}

