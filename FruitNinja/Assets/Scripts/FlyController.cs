using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class FlyController : MonoBehaviour
{
    public float jumpForce = 5f;
    public float flySpeed = 5f;
    public float gravityModifier = 1f; // Adjust this value to modify gravity

    private CharacterController characterController;
    private OVRInput.RawButton jumpButton = OVRInput.RawButton.RIndexTrigger; // Change this to the appropriate button
    private OVRInput.RawButton flyButton = OVRInput.RawButton.LIndexTrigger; // Change this to the appropriate button

    private Vector3 moveDirection = Vector3.zero;
    private bool isJumping = false;
    private bool isFlying = false;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        Debug.Log(isFlying);
        // Adjust global gravity
        Physics.gravity = new Vector3(0, -9.8f * gravityModifier, 0);

        // Check if the fly button is pressed
        if (OVRInput.Get(flyButton) && !isJumping)
        {
            GetComponent<OVRPlayerController>().GravityModifier = 0f;
            isFlying = true;
        }
        else if (!OVRInput.Get(flyButton) && isFlying)
        {
            GetComponent<OVRPlayerController>().GravityModifier = 1f;
            isFlying = false;
        }

        // Check if the jump button is pressed
        if (OVRInput.Get(jumpButton) && !isJumping && !isFlying)
        {
            // Apply jump force
            moveDirection.y = jumpForce;
            GetComponent<OVRPlayerController>().GravityModifier = 0f;
            isJumping = true;
        }

        // Apply gravity if not flying
        if (!isFlying)
        {
            moveDirection.y -= 9.8f * gravityModifier * Time.deltaTime;
        }
        else
        {
            // Apply flying movement
            moveDirection.y = 0f; // Prevent gravity from affecting vertical movement
            moveDirection += transform.up * (flySpeed * OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y);
        }

        // Move the character controller
        characterController.Move(moveDirection * Time.deltaTime);

        // Check if the character is grounded
        if (characterController.isGrounded)
        {
            // If grounded, reset the vertical movement
            moveDirection.y = 0f;
            GetComponent<OVRPlayerController>().GravityModifier = 1f;
            isJumping = false;
        }
    }
}
