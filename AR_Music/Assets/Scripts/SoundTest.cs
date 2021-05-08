using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;

    private int note;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        note = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            PlayNote(note);
        }
    }

    private void PlayNote(int color)
    {
        myAudioSource.clip = aClips[color];
        myAudioSource.Play();

        note++;

        if (note == 7) note = 0;
    }
}
