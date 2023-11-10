using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrzenie : MonoBehaviour
{
    public Transform player;

    public float mouseSensitivity = 100f;
    public float yAngle = 90f;

    private float rotationY = 0f;
    private float rotationX = 0f; 

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = -Input.GetAxis("Mouse Y");

        rotationY += mouseX * mouseSensitivity * Time.deltaTime;
        rotationX += mouseY * mouseSensitivity * Time.deltaTime;

        rotationX = Mathf.Clamp(rotationX, -yAngle, yAngle);

        Quaternion localRotation = Quaternion.Euler(rotationX, rotationY, 0.0f);
        transform.rotation = localRotation;
    }
}
