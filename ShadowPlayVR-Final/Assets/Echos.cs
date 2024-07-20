using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchosMovement : MonoBehaviour
{
    public Transform objectA; // Object A whose movement drives the response
    public Transform objectB; // Object B that responds to Object A's movement
    public float movementScale = 1.0f; // Scale factor for Object B's movement relative to Object A

    private Vector3 previousPositionA; // To store Object A's position from the previous frame

    void Start()
    {
        if (objectA != null)
        {
            // Initialize previousPositionA with objectA's initial position
            previousPositionA = objectA.position;
        }
        else
        {
            Debug.LogError("Object A is not assigned.");
        }
    }

    void Update()
    {
        if (objectA == null || objectB == null) return;

        // Calculate Object A's movement since the last frame
        Vector3 movementA = objectA.position - previousPositionA;

        // Apply the movement to Object B, scaled by movementScale
        objectB.position += movementA * movementScale;

        // Update previousPositionA for the next frame
        previousPositionA = objectA.position;
    }
}