using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeerMovement : MonoBehaviour
{
    public float movementSpeed = 2;
    public float rotationSpeed = 100;

    public Animator animator;

    // Nojsty solution
    public Rigidbody rigBdy;
    Vector3 movement;
    public float mouseSensitivity = 2.0f;

    void Update ()
    {
        // Load input for movement
        movement.x = -Input . GetAxisRaw ( "Horizontal" );
        movement.z = -Input . GetAxisRaw ( "Vertical" );

        // Set speed, so that walking animation is played
        if ( movement.x != 0 || movement.z != 0 )
            animator . SetFloat ( "Speed", 1 );
        else
            animator . SetFloat ( "Speed", 0 );
    }
    
    void FixedUpdate ()
    {
        // Jirka solution
        /*
        if (Input.GetKey("w")) transform.Translate(0, 0, -movementSpeed * Time.fixedDeltaTime);
        if (Input.GetKey("s")) transform.Translate(0, 0, movementSpeed * Time.fixedDeltaTime);

        if (Input.GetKey("a")) transform.Rotate(0, -rotationSpeed * Time.fixedDeltaTime, 0);
        if (Input.GetKey("d")) transform.Rotate(0, rotationSpeed * Time.fixedDeltaTime, 0);
        */

        // Nojsty solution 
        // Add camera rotation to the movement
        Vector3 movementHor = transform.right * movement.x;
        Vector3 movementVer = transform.forward * movement.z;

        movement = ( movementHor + movementVer ) . normalized * movementSpeed;

        // Apply movement
        rigBdy.MovePosition(rigBdy.position + movement * Time.fixedDeltaTime);

        // Rotation based on mouse movement
        float yRotation = Input.GetAxisRaw ( "Mouse X" );
        Vector3 rotation = new Vector3 ( 0.0f, yRotation, 0.0f ) * mouseSensitivity;

        // Apply rotation
        rigBdy.MoveRotation ( rigBdy.rotation * Quaternion.Euler ( rotation ) );

    }
}
