using UnityEngine;

public class SirenAudio : MonoBehaviour
{
    public AudioClip siren;
    private AudioSource audioSource;
    private bool isPlaying = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the AudioSource component attached to the same GameObject
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !isPlaying)
        {
            // Play the audio clip
            audioSource.PlayOneShot(siren);
            isPlaying = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player") && isPlaying)
        {
            // Stop the audio playback
            audioSource.Stop();
            isPlaying = false;
        }
    }
}
