using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feedback : MonoBehaviour
{
    public Material[] materials;
    Renderer rend;

    public SoundTest script;

    private float timer;
    private float feedbackTime = 0.2f;

    bool startedFeedback = false;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = materials[0];

        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (startedFeedback)
        {
            timer += Time.deltaTime;

            if (timer >= feedbackTime)
            {
                startedFeedback = false;
                timer = 0f;
                NormalStatus();
            }
        }

        if (script.button_name == transform.name && !startedFeedback)
        {
            PositionFeedback();
            ColorFeedback();

            startedFeedback = true;
        }
    }

    private void PositionFeedback()
    {
        Vector3 newPosition = transform.position;
        newPosition.y -= 0.005f;

        transform.position = newPosition;
    }

    private void ColorFeedback()
    {
        rend.sharedMaterial = materials[1];
    }

    private void NormalStatus()
    {
        rend.sharedMaterial = materials[0];

        Vector3 newPosition = transform.position;
        newPosition.y += 0.005f;

        transform.position = newPosition;
    }
}
