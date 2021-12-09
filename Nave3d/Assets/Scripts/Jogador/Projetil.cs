using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float forca;
    //public float rotForca;

    void Start()
    {

        GetComponent<Rigidbody>().AddForce(Vector3.forward * forca);
        Destroy(gameObject, 15.0f);
    }

    void Update()
    {
        //transform.Rotate(Vector3.up, rotForca * Time.deltaTime);
    }


}
