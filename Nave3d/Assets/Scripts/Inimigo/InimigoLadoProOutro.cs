using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoLadoProOutro : MonoBehaviour
{
    public float velocidadeX = 5.0f;
    public float velocidadeY = 5.0f;
    public float intervalo = 0.9f;
    public GameObject projetil;
    void Start()
    {
        StartCoroutine(Bala());
    }

    
    void Update()
    {
        if (transform.position.x < -2.74 || transform.position.x > 2.9f)
        {
            velocidadeX = velocidadeX * -1;
        }
        if (transform.position.y < -3.5f || transform.position.y > 3.5f)
        {
            velocidadeY = velocidadeY * -1;
        }

        transform.Translate(velocidadeX * Time.deltaTime, 0.0f, 0.0f);
    }
    IEnumerator Bala()
    {
        yield return new WaitForSeconds(intervalo);
        Instantiate(projetil, transform.position, transform.rotation);
        //Vector3 novaPosicao = new Vector3(Random.Range(-8.025f, -3.986f), Random.Range(0.0f, 3.0f), 18.0f);
        StartCoroutine(Bala());
    }
}
