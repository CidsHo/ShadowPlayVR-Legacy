using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiggleShadowPuppet : MonoBehaviour
{
    public float maxAngle = 15.0f; // Maximum wiggle angle
    public float wiggleSpeed = 5.0f; // Speed of the wiggle
    public float damping = 1.0f; // How quickly the wiggle settles down

    private float timePassed = 0f;

    void OnEnable()
    {
        StartCoroutine(Wiggle());
    }

    IEnumerator Wiggle()
    {
        while (maxAngle > 0.01f)
        {
            // Calculate the current angle using a sine wave
            float angle = maxAngle * Mathf.Sin(timePassed * wiggleSpeed);
            // Apply the rotation around the Z-axis
            transform.localRotation = Quaternion.Euler(0, 0, angle);

            // Increase the time passed
            timePassed += Time.deltaTime;
            // Dampen the wiggle effect over time
            maxAngle -= Time.deltaTime * damping;

            yield return null;
        }

        // Optionally, reset the object to its original rotation after the wiggle
        transform.localRotation = Quaternion.identity;
    }
}
