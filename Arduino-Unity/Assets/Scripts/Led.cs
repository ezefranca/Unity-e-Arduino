using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Led : MonoBehaviour
{
    // Start is called before the first frame update
    Color oldcolor;

    void Start()
    {
        oldcolor = GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (ArduinoControl.status == 2)
        {
            
            GetComponent<Renderer>().material.color = oldcolor + Color.white / 2;
        }
        else
        {
            GetComponent<Renderer>().material.color = oldcolor;
        }
    }
}
