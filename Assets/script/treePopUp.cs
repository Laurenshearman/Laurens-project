using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treepopup : MonoBehaviour
{
    public GameObject popupPanel; // Reference to the popup panel GameObject

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Activate the popup panel GameObject
            popupPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Deactivate the popup panel GameObject when the player exits the trigger zone
            popupPanel.SetActive(false);
        }
    }
}




