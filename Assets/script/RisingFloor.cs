using System.Collections;
using UnityEngine;

public class RisingWater : MonoBehaviour
{
    public float riseSpeed = 1.0f; // Speed at which the water rises
    private bool isRising = false; // Flag to track if the water is rising

    void Update()
    {
        if (isRising)
        {
            // Increase the position of the water gradually over time
            transform.position += Vector3.up * riseSpeed * Time.deltaTime;
        }
    }

    public void StartRising()
    {
        isRising = true;
    }

    public void StopRising()
    {
        isRising = false;
    }
}
