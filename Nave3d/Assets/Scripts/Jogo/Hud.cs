using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public Text tVida;
    public static int vida;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        tVida.text = vida.ToString() ;
    }
}
