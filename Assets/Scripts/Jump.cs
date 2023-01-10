using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float force = 500;
    public float force_air = 250;

    public int jumps_max = 2;
    int jumps;
    GrounDetecto_Raycast ground;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody2D>(); 
        ground = GetComponent<GrounDetecto_Raycast>();
    }

    // Update is called once per frame
    void Update()
    {
        // reseteo contador ( si está en el suelo, los saltos son = a los saltos maximos)
        if (ground.grounded)
        {
            jumps = jumps_max;
        }

        // para que el segundo salto sea menos fuerte que el primero lo hacemos asi
        

        if (Input.GetButtonDown("Jump") && jumps > 0)
        {
            jumps--;

            if (ground.grounded)
            {
                rb.AddForce(new Vector2(0,force));

            }
            else 
            {
                rb.AddForce(new Vector2(0, force_air));
            }    
        }
    }
}
