﻿using System.Collections;
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
            NameCompany1.tip1 = input.text + " rất hiểu khách và có dịch vụ chăm sóc rất tuyệt vời.";
            NameCompany2.tip2 = "Sản phẩm của " + input.text + " không quá tệ. Nhưng tôi nghĩ họ vẫn nên cải thiện dịch vụ chăm sóc khách hàng.";
<<<<<<< HEAD
            NameCompany3.tip3 = "Sản phẩm của " + input.text + " không quá tệ. Nhưng tôi nghĩ họ vẫn nên cải thiện dịch vụ chăm sóc khách hàng.";
            SceneManager.LoadScene(4);
=======
            SceneManager.LoadScene(5);
>>>>>>> b0ce02a1e5a39f60de0c5b6c16a5e9bd7f357a82
		}
	}
}