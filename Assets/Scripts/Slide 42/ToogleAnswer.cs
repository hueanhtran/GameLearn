using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ToogleAnswer : MonoBehaviour
{
    public GameObject daA,daB,daC;
    public GameObject slide48, slide49, slide50;
    public bool isA = false;
    public bool isB = false;
    public bool isC = false;

    public void getToogleA() {
        isA = !isA;
        isB = false;
        isC = false;
    }
    public void getToogleB() {
        isB = !isB;
        isA = false;
        isC = false;
    }
    public void getToogleC() {
        isC = !isC;
        isA = false;
        isB = false;
    }
    public void CheckAnswer() {
        if (!isA && !isB && !isC) {
            Debug.Log("No");
        } else {
            if (isA || isC) {
                slide48.SetActive(false);
                if (slide49 != null)
                {
                    MoneyModel2.moneyValue -= 50;
                    bool isActive2 = slide49.activeSelf;
                    slide49.SetActive(true);
                }
            }
            if (isB) {
                slide48.SetActive(false);
                if (slide50 != null)
                {
                    MoneyModel2.moneyValue += 100;
                    bool isActive2 = slide50.activeSelf;
                    slide50.SetActive(true);
                }
            }
        }
    }

}
