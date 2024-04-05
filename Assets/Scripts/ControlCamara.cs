using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{

    public float sensibilidad = 80f;

    public Transform cuerpojugador;
    public Joystick cameraJoystick;

    float rotacionX = 0;

    // Start is called before the first frame update
    void Start()
    {
        // Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX=cameraJoystick.Horizontal * sensibilidad * Time.deltaTime;
        float mouseY = -(cameraJoystick.Vertical * sensibilidad * Time.deltaTime);

        rotacionX += mouseY;
        rotacionX = Mathf.Clamp(rotacionX, -90f,90f);
        transform.localRotation = Quaternion.Euler(rotacionX, 0,0);
        cuerpojugador.Rotate(Vector3.up*mouseX);
    }
}
