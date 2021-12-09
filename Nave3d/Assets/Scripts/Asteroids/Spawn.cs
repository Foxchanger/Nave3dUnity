using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    public GameObject asteroid1, asteroid2, asteroid3;
    public float intervalo, limiteX, limiteY;

    void Start()
    {
        StartCoroutine(Asteroid(intervalo));
    }



    IEnumerator Asteroid(float t)
    {
        yield return new WaitForSeconds(t);

        Vector3 novaPosicao = new Vector3(limiteX, limiteY, 18.0f);

        Instantiate(asteroid1, novaPosicao, transform.rotation);
       

        StartCoroutine(Asteroid(intervalo));
    }
}
