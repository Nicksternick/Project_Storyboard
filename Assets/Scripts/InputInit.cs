using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputInit : MonoBehaviour
{

    public GameObject inputManager;
    public GameObject[] inputManagers = new GameObject[5];


    // Start is called before the first frame update
    void Start()
    {
        //debug check for number of gamepads
        Debug.Log(Gamepad.all.Count);

        

        //instantiate all of the gamepad input managers
        for (int i = 0; i < (Gamepad.all.Count <= 4? Gamepad.all.Count: 4); i++)
        {
            inputManagers[i + 1] = (Instantiate(inputManager));
            inputManagers[i + 1].GetComponent<InputManage>().inputId = i;
            inputManagers[i + 1].GetComponent<InputManage>().gamepadId = Gamepad.all[i];
            inputManagers[i + 1].GetComponent<InputManage>().isGamepad = true;
        }

        //instantiate keyboard as input object
        inputManagers[0] = (Instantiate(inputManager));
        inputManagers[0].GetComponent<InputManage>().inputId = -1;
    }

    // Update is called once per frame
    void Update()
    {
        ///we fiix later
        //for (int i = 1; i < 1; i++)
        //{
        //    if(inputManagers[i + 1].GetComponent<InputManage>().gamepadId == null)
        //    {
        //        inputManagers[i + 1] = null;
        //    }
        //}
    }

    
}
