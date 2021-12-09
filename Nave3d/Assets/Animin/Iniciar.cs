using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Iniciar : MonoBehaviour
{
    public GameObject uiText;
    public float comeco,fim ;

    
    void Start()
    {
        StartCoroutine(Piscando());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Piscando()
    {
        yield return new WaitForSeconds(comeco);
        uiText.SetActive(false);

        yield return new WaitForSeconds(fim);
        uiText.SetActive(true);
        StartCoroutine(Piscando());


    }
}
