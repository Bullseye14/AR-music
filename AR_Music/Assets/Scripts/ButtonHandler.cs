using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;

    public void ChangeInstrument_()
    {
        PlayNote(0);
    }

    private void PlayNote(int color)
    {
        myAudioSource.clip = aClips[color];
        myAudioSource.Play();
    }
}
