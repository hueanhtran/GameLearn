using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AutoShowMoney : MonoBehaviour
{
    public GameObject Money, CanvasFeedback;

    public bool isClick = false;
    void Start(){
        StartCoroutine(Show(Money,0.5f));
        StartCoroutine(Hidden(Money,2.0f));
    }
    IEnumerator Show(GameObject obj, float seconds) {
        yield return new WaitForSeconds(seconds);
        if (obj != null) {
            bool isActive = obj.activeSelf;
            MoneyModel.scoreValue += 120;
            obj.SetActive(true);
		}
	}

    IEnumerator Hidden(GameObject obj, float seconds) {
        yield return new WaitForSeconds(seconds);
        isClick = true;
        obj.SetActive(false);
	}

    public void closePopupFeedback() {
        if (isClick) {
            CanvasFeedback.SetActive(false);
        }
    }
}
