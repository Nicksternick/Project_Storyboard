using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputInit : MonoBehaviour
{

    public GameObject inputManager;
    private List<GameObject> inputManagers = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        //debug check for number of gamepads
        Debug.Log(Gamepad.all.Count);

        

        //instantiate all of the gamepad input managers
        for (int i = 0; i < Gamepad.all.Count; i++)
        {
            inputManagers.Add(Instantiate(inputManager));
            inputManagers[i].GetComponent<InputManage>().inputId = i;
            inputManagers[i].GetComponent<InputManage>().gamepadId = Gamepad.all[i];
            inputManagers[i].GetComponent<InputManage>().isGamepad = true;
            //InputSystem.AddDevice(Gamepad.all[i]);
            //InputSystem.AddDeviceUsage(Gamepad.all[i], $"Gamepad {i}");
        }

        //instantiate keyboard as input object
        inputManagers.Add(Instantiate(inputManager));
        inputManagers[inputManagers.Count-1].GetComponent<InputManage>().inputId = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
