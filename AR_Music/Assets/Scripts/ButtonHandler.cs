using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;

    public SoundTest soundTest;

    public void ChangeInstrument_()
    {
        if (soundTest.instrument == 1) soundTest.instrument = 2;
        else if (soundTest.instrument == 2) soundTest.instrument = 3;
        else if (soundTest.instrument == 3) soundTest.instrument = 1;
    }
}
