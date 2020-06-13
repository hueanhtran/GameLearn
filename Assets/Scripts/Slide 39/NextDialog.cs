using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class NextDialog : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject slide40, Box;


    public void CloseDialog()
    {
        StartCoroutine(Close(0.5f));

    }
    IEnumerator Close(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Box.SetActive(false);
        if (slide40 != null)
        {
            slide40.SetActive(true);
        }

    }

}
