using UnityEngine;

public class MainCamera : MonoBehaviour
{
    Camera _camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = GetComponent<Camera>();
    }

    void FixedUpdate()
    {
        
    }
}
