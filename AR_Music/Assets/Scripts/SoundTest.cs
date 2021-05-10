using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTest : MonoBehaviour
{
    public AudioClip[] aClips;
    public AudioSource myAudioSource;

    public int size = 2;

    private int note;

    string button_name;

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
            ScreenTapped();
        }
    }

    private void ScreenTapped()
    {
        if (ButtonTouched())
        {
            ScreenCapture.CaptureScreenshot($"Assets/Screenshots/Screenshot.png", size);
        }
        else
            PlayNote(note);
    }

    private bool ButtonTouched()
    {
        bool ret = false;

        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        { 
            button_name = hit.transform.name;
            if (button_name == "Screenshot Button") 
            { 
                ret = true; 
            }
        }

        return ret;
    }

    private void PlayNote(int color)
    {
        myAudioSource.clip = aClips[color];
        myAudioSource.Play();

        note++;

        if (note == 7) note = 0;
    }
}
