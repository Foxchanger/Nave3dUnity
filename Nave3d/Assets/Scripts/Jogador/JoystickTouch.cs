using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickTouch : MonoBehaviour
{
    public  Joystick joystick;
    //public  JoyButton joybutton;
    public int velocidadeX, velocidadeY;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //joystick = FindObjectsOfType<Joystick>();
        //joybutton = FindObjectsOfType<JoyBotton>();


        
    }

    // Update is called once per frame
    void Update()
    {
        var rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(joystick.Horizontal * velocidadeX, joystick.Vertical * velocidadeY, rigidbody.velocity.z);

    }
}
