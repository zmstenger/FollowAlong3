using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace _app.Scripts.Player
{
    public class CharacterController : MonoBehaviour
    {
        [Header("Movement Components")]
        public float movementSpeed;
        public Vector2 movementVector;
        public Vector3 jumpForce;
        public bool crouching;

        [Header("Player Components")]
        public Rigidbody rb;
        public Camera playerCamera;
        public PlayerInput pInput;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true; // Freeze rotation to prevent falling over
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerJump();
            }

            movementVector.x = Input.GetAxis("Horizontal");
            movementVector.y = Input.GetAxis("Vertical");

            PlayerMovement(movementVector);
        }

        private void PlayerJump()
        {
            rb.AddForce(jumpForce, ForceMode.Impulse);
        }

        private void PlayerMovement(Vector2 movement)
        {
            Vector3 move = transform.right * movement.x + transform.forward * movement.y;
            rb.MovePosition(rb.position + move * movementSpeed * Time.deltaTime);
        }
    }
}