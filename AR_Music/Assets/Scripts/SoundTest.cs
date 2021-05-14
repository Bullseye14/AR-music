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
        ButtonTouched();
    }

    private void ButtonTouched()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            button_name = hit.transform.name;

            switch (button_name)
            {
                case "C":
                    PlayNote(0);
                    break;

                case "C#":
                    PlayNote(1);
                    break;

                case "D":
                    PlayNote(2);
                    break;

                case "D#":
                    PlayNote(3);
                    break;

                case "E":
                    PlayNote(4);
                    break;

                case "F":
                    PlayNote(5);
                    break;

                case "F#":
                    PlayNote(6);
                    break;

                case "G":
                    PlayNote(7);
                    break;

                case "G#":
                    PlayNote(8);
                    break;

                case "A":
                    PlayNote(9);
                    break;

                case "A#":
                    PlayNote(10);
                    break;

                case "B":
                    PlayNote(11);
                    break;

                case "C'":
                    PlayNote(12);
                    break;

                case "C'#":
                    PlayNote(13);
                    break;

                case "D'":
                    PlayNote(14);
                    break;

                case "D'#":
                    PlayNote(15);
                    break;

                case "E'":
                    PlayNote(16);
                    break;

                default:
                    break;
            }
        }
    }

    private void PlayNote(int color)
    {
        myAudioSource.clip = aClips[color];
        myAudioSource.Play();
    }
}
