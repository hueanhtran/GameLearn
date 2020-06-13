using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource myFX;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void hoverSound()
    {
        myFX.PlayOneShot(hoverFx);
    }
    public void clickSound()
    {
        myFX.PlayOneShot(clickFx);
    }
}
