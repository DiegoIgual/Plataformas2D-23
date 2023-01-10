using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI vidas;
    public GameObject personaje;
    public TextMeshProUGUI time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        time.text = Time.time.ToString("00.00");
        vidas.text = personaje.GetComponent<LifeController>().lifes_current.ToString();
       
    }
}
