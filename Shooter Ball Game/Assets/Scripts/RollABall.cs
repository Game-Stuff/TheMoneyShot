using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollABall : MonoBehaviour
{

    // public declarations
    public float speed;

    // prvate declarations
    private Rigidbody rb;
    private Vector3 movementForceVector;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementForceVector = new Vector3();
    }

    // Update is called once per frame, Before rendering
    void Update()
    {

    }

    // Every Frame, Called before Physics Calculations
    private void FixedUpdate()
    {
        // Get input from player
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        // put input into a Vector3
        movementForceVector.x = moveHorizontal;
        movementForceVector.y = 0.0f;
        movementForceVector.z = moveVertical;

        // Apply vector force to player
        rb.AddForce(movementForceVector * speed);
    }
}