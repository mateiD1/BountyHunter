using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private static Rigidbody _playerBody;
    void Start()
    {
        _playerBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        
    }

    public static Vector3 GetPlayerPosition () => _playerBody.transform.position;
}