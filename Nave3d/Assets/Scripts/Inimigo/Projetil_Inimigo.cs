using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil_Inimigo : MonoBehaviour
{
    public float forca =5000.0f;
    //public float rotForca;

    void Start()
    {

        GetComponent<Rigidbody>().AddForce(Vector3.back * forca);
        Destroy(gameObject, 15.0f);
    }

    void Update()
    {
        //transform.Rotate(Vector3.up, rotForca * Time.deltaTime);
    }


}
