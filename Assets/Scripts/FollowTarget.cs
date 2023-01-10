using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    // pongo el target a seguir
    public Transform target;
    public Vector3 offset;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // posicion actual va a ser igual a target position, después le cambiamos el target.position por un vector3.Lerp para que la camara tenga un poco de delay y no maree ( suavizado de movimiento) 
        transform.position = Vector3.Lerp(transform.position, target.position + offset, speed * Time.deltaTime);
    }
}
