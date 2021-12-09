using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControleJogador : MonoBehaviour
{
    public float sensibilidadeTouch, speedAcelerometro;
    public static bool modoDeJogo;
    


     void Start()
    {
       
    }

    void Update()
    {
        
            //Controle Usando Touch para controlar 
            if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved && modoDeJogo)
            {
                //tCount.text = Input.touchCount.ToString();
                transform.Translate(Input.GetTouch(0).deltaPosition * sensibilidadeTouch * Time.deltaTime);

            }
               
            //Controlar usando acelerometro
            if(!modoDeJogo)
            {
                Vector3 dir = Vector3.zero;

                dir.x = Input.acceleration.x;
                dir.y = Input.acceleration.y;


                if (dir.sqrMagnitude > 1)
                    dir.Normalize();

                dir *= Time.deltaTime;
                transform.Translate(dir * speedAcelerometro);
            }
        

        print(modoDeJogo);
        

        //Limitador de posição em X 
        if (transform.position.x > 2.996f)
        {
            transform.position = new Vector2(2.995f, transform.position.y);
        }
        if(transform.position.x < -2.796f)
        {
            transform.position = new Vector2(-2.795f, transform.position.y);
        }
        //Limitador de posição em Y
        if (transform.position.y < -5.552f)
        {
            transform.position = new Vector2(transform.position.x, -5.551f);
        }

        if (transform.position.y > 5.251f)
        {
            transform.position = new Vector2(transform.position.x, 5.251f);
        }









    }
}

