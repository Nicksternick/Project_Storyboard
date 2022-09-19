using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManage : MonoBehaviour
{
    //-------- FIELDS --------
    public int inputId;
    public bool isGamepad = false;
    public Gamepad gamepadId;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Start of all gamepad input processing
        if (isGamepad)
        {
            if (gamepadId.aButton.IsPressed())
            {
                //Also We need to make sure to code the controllers getting removed so the game doesn't crash
                Debug.Log($":) {inputId}");
            }
        }
        
        //start of all keyboard input processing
        else
        {
            if (Keyboard.current.spaceKey.isPressed)
            {
                Debug.Log($":) {inputId}");
            }
        }
        
    }
}
