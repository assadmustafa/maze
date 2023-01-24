using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AIMovementScript : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float rotationSpeed = 100f;


    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        // rotating
        transform.Rotate(transform.up * Time.deltaTime * rotationSpeed);
        // walking
        //rb.AddForce(transform.forward * movementSpeed);
    }

}
