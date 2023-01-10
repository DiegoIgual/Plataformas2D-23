using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int vidas;
    //public int Score;
    private void Awake()
    {
        instance = this;
    }
}



