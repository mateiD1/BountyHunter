using UnityEngine;

public class MainCamera : MonoBehaviour
{
    private static Camera _camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _camera = GetComponent<Camera>();
        _camera.transform.position.Set(0f, 6f, -7f);
    }

    void FixedUpdate()
    {
        
    }

    void Update()
    {
        checkMouseInput();
    }

    void checkMouseInput()
    {   
        float v = Input.GetAxis("Mouse Y") * 0.5f;

        // negative so when moving mouse up, we look up
        transform.Rotate(-v, 0, 0);
    }
}
