using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// flexible para que sirva para un enemigo que tenga  tres vida , como para mi que tengo 5 o más o menos ( determinamos 2 varaiables, 1 que determine el numero
// máx de vidas y otra que determine : vale tengo este numero máximo de viddas, cuantas me quedan
public class LifeController : MonoBehaviour
{
    public int lifes_current;
    public int life_max;
    public float invencible_time;
    bool invencible;

    public enum DeathMode { Teleport, ReloadScene, Destroy }
    public DeathMode death_mode;
    public Transform respawn;

    Rigidbody2D rb;

    // vidas actuales = a las vidas máximas, para que nada más empezar tengamos el máximo de vidas
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lifes_current = life_max;
    }

    // Update is called once per frame
   public void Damage(int damage = 1, bool ignoreInvencible = false)
   {
        if(!invencible || ignoreInvencible) 
        {
            lifes_current -= damage;
            StartCoroutine(Invencible_Corutine());
            if(lifes_current <= 0)
            {
                Death();
            }
        }
   }      

    public void Death()
    {
        Debug.Log("Has muerto");
        switch (death_mode)             
        {
            case DeathMode.Teleport:
                rb.velocity = new Vector2(0, 0);
                transform.position = respawn.position;
                lifes_current = life_max;
                break;
            case DeathMode.ReloadScene:
                break;
            case DeathMode.Destroy:
                Destroy(gameObject);
                break;
            default:
                break;
        }
    }
    IEnumerator Invencible_Corutine()
    {
        invencible= true;
        yield return new WaitForSeconds(invencible_time);
        invencible= false;
    }
}

