using System;
using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    private static Rigidbody _playerBody;
    private bool _canJump;
    void Start()
    {
        _playerBody = GetComponent<Rigidbody>();
        _playerBody.MovePosition(new Vector3(0f, 2f, 0f));
        _playerBody.mass = 10f;
        _playerBody.detectCollisions = true;
        
        _canJump = true;
    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {
        checkKeyboardInputs();
    }

    void OnCollisionEnter(Collision collision)
    {
        _canJump = true;
    }

    void checkKeyboardInputs()
    {
        float jump = 0f;
        if (Input.GetKey(KeyCode.Space) && _canJump)
        {
            jump = 30f;
            _canJump = false;
        }

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float mouseY = Input.GetAxis("Mouse X") * 0.5f;

        Vector3 movement = new Vector3(horizontal, jump, vertical);
        float speed = 20f;
        transform.Translate(movement * speed * Time.deltaTime);
        transform.Rotate(0, mouseY, 0);

        // mouse should remain in the middle, so it never hits the wall and the user can turn endlessly
    }
}