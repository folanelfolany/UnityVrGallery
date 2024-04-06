using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component

    void Start()
    {
        // Assuming your AudioSource component is attached to the same GameObject as this script
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    // This function is called when the button is clicked
    public void OnButtonClick()
    {
        // Play the audio file
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogError("Audio source is not assigned!");
        }
    }
}
