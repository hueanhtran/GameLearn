using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Controller2 : MonoBehaviour
{
    public GameObject QS1,QS2,QS3,slide34, slide35, slide36, slide37,slide38,slide39, slide40;
    public void ClickHow()
    {
        QS1.SetActive(false);
        if (slide35 != null)
        {
            bool isActive2 = slide35.activeSelf;
            slide35.SetActive(true);
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
    public void ClickDo()
    {
        /*SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("LOCK");
        Application.Quit();*/

        QS2.SetActive(false);
        if (slide36 != null)
        {
            bool isActive2 = slide36.activeSelf;
            slide36.SetActive(true);
        }

    }
    public void ClickCan()
    {
        QS3.SetActive(false);
        if (slide37 != null)
        {
            bool isActive2 = slide37.activeSelf;
            slide37.SetActive(true);
        }
    }
    
    public void ClickXbutton35()
    {
        slide35.SetActive(false);
        if (QS1 != null)
        {
            bool isActive3 = QS1.activeSelf;
            QS1.SetActive(true);
        }
    }
    public void ClickXbutton36()
    {
        slide36.SetActive(false);
        if (QS2 != null)
        {
            bool isActive3 = QS2.activeSelf;
            QS2.SetActive(true);
        }
    }
    public void ClickXbutton37()
    {
        slide37.SetActive(false);
        if (QS3 != null)
        {
            bool isActive3 = QS3.activeSelf;
            QS3.SetActive(true);
        }
    }
    public void ClickButton35()
    {
        slide38.SetActive(false);
        if (slide39 != null)
        {
            bool isActive3 = slide39.activeSelf;
            slide39.SetActive(true);
        }
    }
   
    public void buttonContinue()
    {
        slide34.SetActive(false);
        if (slide38!=null)
        {
            slide38.SetActive(true);
        }
    }
    public void buttonContinue38()
    {
        slide38.SetActive(false);
        if (slide39 != null)
        {
            slide39.SetActive(true);
        }
    }
    public void ClickXbutton39()
    {
        slide39.SetActive(false);
        if (slide40 != null)
        {
            bool isActive3 = slide40.activeSelf;
            slide40.SetActive(true);
        }
    }
}

