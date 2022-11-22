using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOnOffMachines : MonoBehaviour
{
    [SerializeField] public bool actived;
    public int machineIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public int Interact()
    {
        actived = !actived;
        if (actived)
        {
            Debug.Log("Machine Actived");
        }
        if (!actived)
        {
            Debug.Log("Machine has turned off");

        }
        Debug.Log(machineIndex);
        return machineIndex;
    }
}
