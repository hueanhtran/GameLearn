using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPopup : MonoBehaviour
{   
    public GameObject popup;
    //public GameObject options;
    //public GameObject muiten;
    void Start(){
        StartCoroutine(Show(popup,1.0f));
    }
    IEnumerator Show(GameObject obj, float seconds) {
        yield return new WaitForSeconds(seconds);
        if (obj != null) {
            bool isActive = obj.activeSelf;
            obj.SetActive(true);
		}
	}
}
