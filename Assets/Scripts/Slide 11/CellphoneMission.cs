using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CellphoneMission : MonoBehaviour
{
    
    //public GameObject Slide12;

    public void OpenPanel()
    {

        StartCoroutine(Wait(1.0f));
    }

    IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}