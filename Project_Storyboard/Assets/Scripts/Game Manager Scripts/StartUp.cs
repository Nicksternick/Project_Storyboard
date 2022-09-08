using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;

/// <summary>
/// Author: Patrick Emmons, Nicholas DiGiovanni
/// Purpose: Instantiates 
/// </summary>
public class StartUp : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        // Show all gamepads in the system.
        Debug.Log(string.Join("\n", Gamepad.all));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
