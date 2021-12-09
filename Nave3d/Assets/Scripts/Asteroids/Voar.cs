using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voar : MonoBehaviour
{

    public float forca;
    

    void Start()
    {

        GetComponent<Rigidbody>().AddForce(Vector3.up * forca);
        Destroy(gameObject, 15.0f);
    }

}
