using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] bool canInteract;
    [SerializeField] GameObject machinePuzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&& canInteract)
        {
            machinePuzzle.GetComponent<TurnOnOffMachines>().Interact();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Machine")
        {
            canInteract = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Machine")
        {
            canInteract = false;
        }
    }
}
