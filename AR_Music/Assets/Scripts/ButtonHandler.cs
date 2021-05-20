using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Sprite guitarSprite;
    public Sprite trumpetSprite;
    public Sprite pianoSprite;

    public Button button;

    public SoundTest soundTest;

    public void ChangeInstrument_()
    {
        switch(soundTest.instrument)
        {
            case 1:
                soundTest.instrument = 2;
                button.image.sprite = guitarSprite;
                break;

            case 2:
                soundTest.instrument = 3;
                button.image.sprite = trumpetSprite;
                break;

            case 3:
                soundTest.instrument = 1;
                button.image.sprite = pianoSprite;
                break;
        }
    }
}
