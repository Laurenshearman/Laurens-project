using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeInteraction : MonoBehaviour
{
    public GameObject treePrefab; // Reference to the tree prefab to instantiate
    public float plantingRadius = 3f; // Maximum distance from the tree where new trees can be planted
    public int maxTrees = 10; // Maximum number of trees that can be planted

    private bool isInRange = false;
    private List<Vector3> plantedTreePositions = new List<Vector3>(); // List to store positions of planted trees

    void Update()
    {
        if (isInRange && Input.GetKeyDown(KeyCode.E))
        {
            PlantTree();
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

    void PlantTree()
    {
        // Check if the maximum number of trees has been reached
        if (plantedTreePositions.Count >= maxTrees)
        {
            Debug.Log("Maximum number of trees planted");
            return;
        }

        // Generate a random position around the existing tree within the planting radius
        Vector2 randomDirection = Random.insideUnitCircle.normalized * plantingRadius;
        Vector3 spawnPosition = transform.position + new Vector3(randomDirection.x, 0f, randomDirection.y);

        // Check if the new position is too close to an existing tree
        foreach (Vector3 position in plantedTreePositions)
        {
            if (Vector3.Distance(spawnPosition, position) < plantingRadius)
            {
                Debug.Log("Cannot plant tree, too close to existing tree");
                return;
            }
        }

        Quaternion spawnRotation = Quaternion.identity;
        Instantiate(treePrefab, spawnPosition, spawnRotation);

        // Add the position of the new tree to the list of planted tree positions
        plantedTreePositions.Add(spawnPosition);
    }
}
