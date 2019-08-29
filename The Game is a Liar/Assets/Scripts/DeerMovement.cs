using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerMovement : MonoBehaviour
{
    public float movementSpeed = 2;
    public float rotationSpeed = 100;

    void FixedUpdate()
    {
        if (Input.GetKey("w")) transform.Translate(0, 0, -movementSpeed * Time.deltaTime);
        if (Input.GetKey("s")) transform.Translate(0, 0, movementSpeed * Time.deltaTime);

        if (Input.GetKey("a")) transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
        if (Input.GetKey("d")) transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
