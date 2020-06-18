using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using UnityEngine.SceneManagement;

public class CheckEmptyName : MonoBehaviour
{
     public void CheckIsEmptyName(InputField input){
        StartCoroutine(Check(1.0f, input));
	}
    IEnumerator Check(float seconds,InputField input) {
        yield return new WaitForSeconds(seconds);
        if (input.text != "") {
            SceneManager.LoadScene(5);
		}
	}
}
