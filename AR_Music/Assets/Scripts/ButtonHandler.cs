using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public Sprite normalSprite;
    public Sprite selectedSprite;

    public Sprite otherSprite1, otherSprite2;

    public Button button;

    // Passem a cada botó els altres dos botons amb els seus sprites normals
    public Button otherButton1, otherButton2;

    public SoundTest soundTest;

    public void ChangeInstrument_()
    {
        // Cada vegada que cliquem un botó, aquest canviarà a selected, i els altres dos a no selected
        button.image.sprite = selectedSprite;
        otherButton1.image.sprite = otherSprite1;
        otherButton2.image.sprite = otherSprite2;

        switch (button.name)
        {
            case "PianoButton":
                soundTest.instrument = 1;
                break;

            case "GuitarButton":
                soundTest.instrument = 2;
                break;

            case "TrumpetButton":
                soundTest.instrument = 3;
                break;

            default:
                break;
        }
    }
}
