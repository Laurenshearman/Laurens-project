using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingFloor : MonoBehaviour
{
    public float riseSpeed = 1.0f; // Speed at which the floor rises
    public float maxHeight = 10.0f; // Maximum height for the floor

    private void Update()
    {
        // Increase the position of the floor gradually over time
        transform.position += Vector3.up * riseSpeed * Time.deltaTime;

        // Clamp the position to the maximum height
        transform.position = new Vector3(transform.position.x, Mathf.Min(transform.position.y, maxHeight), transform.position.z);
    }
}
