using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador: MonoBehaviour{
    CharacterController _characterController;
    Animator _animator;

    Vector3 movimiento;
    Vector3 gravedad;
    
    bool estasEnSuelo;

    public float velocidad = 10f;
    float fuerzaGravedad = -9.8f;
    public float radioEsferaSuelo = 0.3f;

    public LayerMask mascaraSuelo;
    public Joystick joystickmovimiento;

    public Transform checadorSuelo;
    void Start(){
        _characterController = GetComponent<CharacterController>();
        _animator = GetComponentInChildren<Animator>();
    }

    void Update(){
        Movimiento();
        Animaciones();
    }
    private void Movimiento(){
        estasEnSuelo = Physics.CheckSphere(checadorSuelo.position, radioEsferaSuelo, mascaraSuelo);
        if(estasEnSuelo && gravedad.y < 0){
            gravedad.y = -2;
        }
        float x = joystickmovimiento.Horizontal;
        float z = joystickmovimiento.Vertical;
        movimiento = transform.right * x + transform.forward *z;
        _characterController.Move(movimiento * velocidad * Time.deltaTime);

        gravedad.y += fuerzaGravedad * Time.deltaTime;
        _characterController.Move(gravedad * Time.deltaTime);
    }

    private void Animaciones(){
        // _animator.SetFloat("Caminar", Math.Abs(movimiento.magnitude));
    }
}