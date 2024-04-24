using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject interactionPanel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            interactionPanel.SetActive(false);
        }
    }

    public void OnButtonClicked()
    {
        // Implement button click behavior here
        // This method will be called when the button is clicked
        Debug.Log("Button clicked");
        interactionPanel.SetActive(false);
    }
}
