using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public GameObject textPanelGameObject; // Reference to the GameObject containing the text panel
    public string[] lines;
    public float textSpeed;
    private int index;

    private bool isInRange = false;

    void Start()
    {
        textComponent.text = string.Empty;
        // Deactivate the text panel GameObject at the start
        textPanelGameObject.SetActive(false);
    }

    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            StartDialogue();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInRange = false;
        }
    }

    void StartDialogue()
    {
        // Check if there are dialogue lines to display
        if (index < lines.Length)
        {
            // Activate the GameObject containing the panel
            textPanelGameObject.SetActive(true);
            
            // Display the current line of dialogue
            textComponent.text = lines[index];
            
            // Move to the next line
            index++;
        }
        else
        {
            // If there are no more dialogue lines, deactivate only the text panel GameObject
            textPanelGameObject.SetActive(false);
        }
    }
}
