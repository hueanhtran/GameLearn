using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MoneyTips : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject money, slide40, Box;
    

    void Start()
    {
        
        //xuat hien sau 3s
        {
            StartCoroutine(Show(money, 3.0f));
        }
        IEnumerator Show(GameObject obj, float seconds)
        {
            yield return new WaitForSeconds(seconds);
            if (obj != null)
            {
                obj.SetActive(true);
            }
        }
    }
    public void ClickButton(GameObject obj)
    {
        ScoreScript.scoreValue += 120;
        obj.SetActive(false);

    }
   
}
    
