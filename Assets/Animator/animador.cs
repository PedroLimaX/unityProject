using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animador : MonoBehaviour
{
    
    public float x,z;
    private Animator anim;
    public Controlador movimientos;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        movimientos=FindObjectOfType<Controlador>();
    }

    // Update is called once per frame
    void Update()
    {
        x=movimientos.joystickmovimiento.Horizontal;
        z=movimientos.joystickmovimiento.Vertical;
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelZ", z);
    }
}
