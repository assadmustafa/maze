using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMove : MonoBehaviour
{
    // reverse gravity
    private bool reverseGravity = false;

    public CharacterController charController; // Publicly define our character controller
    public bool canJump; // Enable this in the inspector if you want the player to jump
    private bool midAirJump;
    public float walkSpeed = 2.5f;
    public float runSpeed = 5f;
    public float gravity = -9.81f;
    public float jumpHeight = 1f;
    public Transform groundCheck; // The transform of our "Ground Check" object. Used to determine if we are on the ground
    public float groundDistance = 0.05f;
    public LayerMask groundMask; // Set a field for our "Ground" layer
    float speed; // Update-able moving speed

    Vector3 velocity;
    public bool grounded; // Defines is the player is touching the ground
    public bool fly;
    private void Update() // Called once per frame
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask); // Checks if our player is touching an object with a "Ground" layer and sets the boolean accordingly

        if (grounded && velocity.y < 0) // If the player is grounded
        {
            velocity.y = -2f; // Set the downward velocity to 2
        }

        if (Input.GetKey(KeyCode.LeftShift)) // If the left shift button is being pressed
        {
            speed = runSpeed; // Set our speed to runSpeed
        }
        else
        {
            speed = walkSpeed;// Set our speed to walkSpeed
        }

        float x = Input.GetAxis("Horizontal"); // Define an X variable and set it to Unity's "Horizontal" axis
        float z = Input.GetAxis("Vertical"); // Define a Y variable and set it to Unity's "Vertical" axis

        Vector3 move = transform.right * x + transform.forward * z; // Define our move vector

        charController.Move(move * speed * Time.deltaTime); // Move our character controller based on our set inputs


        if (Input.GetButtonDown("Jump")) // Unity's default input for "Jump" is the space key
        {
            if (fly)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // Set our jumping gravity 
            }
            if (grounded)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); // Set our jumping gravity 
                midAirJump = true; // Set mid air jump to true in order to double jump
            }
            else if (midAirJump)
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); //Set our jumping gravity 
                midAirJump = false;// disable double jump
            }
        }

        if (reverseGravity)
        {
            velocity.y -= gravity * Time.deltaTime; // Set our regular gravity
        }
        else
        {
            velocity.y += gravity * Time.deltaTime;
        }
        

        charController.Move(velocity * Time.deltaTime); // Apply our gravity to our character controller
    }

    private void OnTriggerEnter(Collider other) // Will be called when the player enters the End Cube trigger box
    {
        Scene currentScene = SceneManager.GetActiveScene(); // Declare a variable for our current scene

        if (other.gameObject.CompareTag("monster"))
        {
            SceneManager.LoadScene("Menu"); // Load Menu scene
        }

        if (other.gameObject.CompareTag("rotater"))
        {
            reverseGravity = true;
            walkSpeed = 5;
            runSpeed = 10;
        }

        if (other.gameObject.CompareTag("teleporter"))
        {
            SceneManager.LoadScene("Menu"); // Load Menu scene
        }

    }

}