using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arma_Inimigo : MonoBehaviour
{
    public GameObject projetil;
    //public float  limiteX, limiteY;
    public float intervalo;

    void Start()
    {
        StartCoroutine(Bala());
    }



    IEnumerator Bala()
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(projetil,transform.position , transform.rotation);
        //Vector3 novaPosicao = new Vector3(Random.Range(-8.025f, -3.986f), Random.Range(0.0f, 3.0f), 18.0f);
        StartCoroutine(Bala());
    }
}
