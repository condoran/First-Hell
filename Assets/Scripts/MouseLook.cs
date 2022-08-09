using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    [SerializeField] float mouseSensitivity = 50f;
    
    private float mouseX;
    private float mouseY;
    private float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mouseX = UnityEngine.InputSystem.Mouse.current.delta.x.ReadValue() * mouseSensitivity * Time.deltaTime;
        mouseY = UnityEngine.InputSystem.Mouse.current.delta.y.ReadValue() * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerTransform.Rotate(Vector3.up * mouseX);
    }
}
