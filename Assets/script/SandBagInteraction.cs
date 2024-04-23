using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SandbagInteraction : MonoBehaviour
{
    public RisingWater risingWater; // Reference to the RisingWater script attached to the water object

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Start rising the water when the player enters the trigger zone
            risingWater.StartRising();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Stop rising the water when the player exits the trigger zone
            risingWater.StopRising();
        }
    }
}