using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    Transform cam;
    public Joystick joystickMove;
    public Joystick joystickGiro;
    public Rigidbody rb;
    bool jump;
    float rotateV;
    float rotateH;
    public float speed = 10f;
    public float speedGiro = 0.2f;

    public void Start(){
        cam = Camera.main.transform;
    }
    void Move(){
        rb.velocity = new Vector3(joystickMove.Horizontal * speed + Input.GetAxis("Horizontal"), rb.velocity.y, joystickMove.Vertical * speed + Input.GetAxis("Vertical"));

    }
    
    public void Jump(){
        rb.velocity +=Vector3.up * speed;
    }

    void Rotate(){
        rotateH = joystickGiro.Horizontal*speedGiro;
        rotateV = -(joystickGiro.Vertical*speedGiro);
        cam.Rotate(rotateH, rotateV, 0);
    }
    private void Update(){
        Move();
        //Rotate();
    }
}
