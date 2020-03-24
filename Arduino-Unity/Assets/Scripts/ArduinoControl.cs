using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class ArduinoControl : MonoBehaviour
{
    public string portName;
    SerialPort arduino;
    public static int status = 0;

    void Start()
    {
        portName = "/dev/cu.usbserial-1410";
        arduino = new SerialPort(portName, 9600);
        arduino.Open();
    }

    void Update()
    {
        if (arduino.IsOpen)
        {
            if (Input.GetKey("1"))
            {
                arduino.Write("1");
                status = 1;
                Debug.Log(1);
            }
            else if (Input.GetKey("2"))
            {
                arduino.Write("2");
                status = 2;
                Debug.Log(2);
            }
        }
    }
}

/*
 NET 2.0 (not subset) and will connect. I was able to transmit data, but not to receive. Config is into Edit>ProjectSettings>Player>ApiCompatibilityLevel.
 */
