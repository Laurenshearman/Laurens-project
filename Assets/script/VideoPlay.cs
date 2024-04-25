using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video; // Import the Video namespace

public class videointeratcion : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public GameObject popupPanel; // Reference to the popup panel GameObject

    void Start()
    {
        // Disable the popup panel and hide the video player initially
        popupPanel.SetActive(false);
        videoPlayer.gameObject.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the popup panel GameObject
            popupPanel.SetActive(true);

            // Show the video player GameObject
            videoPlayer.gameObject.SetActive(true);

            // Play the video
            videoPlayer.Play();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Deactivate the popup panel GameObject when the player exits the trigger zone
            popupPanel.SetActive(false);

            // Pause the video
            videoPlayer.Pause();

            // Hide the video player GameObject
            videoPlayer.gameObject.SetActive(false);
        }
    }
}
