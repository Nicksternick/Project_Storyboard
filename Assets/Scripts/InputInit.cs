using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputInit : MonoBehaviour
{

    public GameObject inputManager;
    private List<GameObject> inputManagers = new List<GameObject>();

    //input count starts at 1 bcs keyboard is always an input
    private int inputCount = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Gamepad.all.Count);

        //instantiate all of the input managers
        for (int i = 0; i < inputCount; i++)
        {
            inputManagers.Add(Instantiate(inputManager));
            inputManagers[i].GetComponent<InputManage>().inputId = i;
            Debug.Log($"input Manager {inputManagers[i].GetComponent<InputManage>().inputId} instantiated.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
