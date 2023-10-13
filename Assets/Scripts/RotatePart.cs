using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePart : MonoBehaviour
{
    public static void Rotate(Part part, int rotationSpeed = 100)
    {
        float transformRotationAmount = rotationSpeed * Time.deltaTime;

        part.Transform.Rotate(Vector3.forward * transformRotationAmount);
        part.Rigidbody2D.angularVelocity = rotationSpeed * 3f;
    }
}
