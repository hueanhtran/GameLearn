using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypingEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public string fullText;
    public string currentText = "";
    int i = 0 ;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowText());
    }

    // Update is called once per frame
    IEnumerator ShowText() {
        for(int i=0; i < fullText.Length; i++) {
            currentText = fullText.Substring(0,i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(0.05f);
        }
    }
}
