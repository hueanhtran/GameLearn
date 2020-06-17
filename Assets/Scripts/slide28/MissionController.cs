using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionController : MonoBehaviour
{
    
    public GameObject ButtonContinueYellow,ButtonOK,RoundMission1,RoundMission2,HeaderMission1,HeaderMission2,Arrow_down,TextHorver,ButtonT,ButtonDoc,Arrow_left;

    public void ClickContinue() {
        ButtonOK.SetActive(true);
        RoundMission2.SetActive(true);
        HeaderMission2.SetActive(true);
        ButtonT.SetActive(true);
        ButtonDoc.SetActive(true);
        Arrow_left.SetActive(true);

        ButtonContinueYellow.SetActive(false);
        RoundMission1.SetActive(false);
        HeaderMission1.SetActive(false);
        TextHorver.SetActive(false);
        Arrow_down.SetActive(false);
    }

    public void NextScreen42(int index)
    {
        SceneManager.LoadScene(index);
    }

}
