using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteraction : MonoBehaviour
{
    public GameObject interactionPanel;

    private bool isInRange = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
            interactionPanel.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
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
