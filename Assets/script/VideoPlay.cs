using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoTrigger : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    private bool hasPlayed = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasPlayed && other.CompareTag("Player"))
        {
            PlayVideo();
            hasPlayed = true;
        }
    }

    private void PlayVideo()
    {
        // Check if the VideoPlayer component is assigned
        if (videoPlayer != null)
        {
            // Play the video
            videoPlayer.Play();
        }
    }
}

