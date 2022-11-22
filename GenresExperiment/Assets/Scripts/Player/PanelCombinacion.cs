using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCombinacion : MonoBehaviour
{

    [SerializeField] string combination = "1324";
    [SerializeField] string playerInputCombination="";
    [SerializeField] int digitosMax = 0;
    [SerializeField] List<GameObject> machinesPuzzle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void EscribirCodigo(int numero)
    //{
    //    digitosMax++;
    //    playerInputCombination += numero;
    //    Debug.Log(playerInputCombination);
    //    if (digitosMax == 4)
    //    {
    //        if (playerInputCombination == combination)
    //        {
    //            Debug.Log("La contraseña correcta es: " + playerInputCombination);
    //        }
    //        else
    //        {
    //            Debug.Log("La contraseña es incorrecta");
    //            playerInputCombination = "";
    //            digitosMax = 0;
    //        }
    //    }
    //}
    public void ProbarCombinacion()
    {
        switch (machinesPuzzle.Count)
        {
            case 0: //1
                machinesPuzzle[0].GetComponent<TurnOnOffMachines>().Interact();

                if (machinesPuzzle.Count == 2) //3
                {
                    machinesPuzzle[2].GetComponent<TurnOnOffMachines>().Interact();
                }
                else
                {
                    ApagarTodasLasMaquinas();
                }
                if (machinesPuzzle.Count == 1) //2
                {
                    machinesPuzzle[1].GetComponent<TurnOnOffMachines>().Interact();
                }
                else
                {
                    ApagarTodasLasMaquinas();
                }
                if (machinesPuzzle.Count == 3) //4
                {
                    machinesPuzzle[3].GetComponent<TurnOnOffMachines>().Interact();
                }
                else
                {
                    ApagarTodasLasMaquinas();
                }

                break;
            default:
                ApagarTodasLasMaquinas();


                break;
        }
    }
    public void ApagarTodasLasMaquinas()
    {
        for (int i =0; i<machinesPuzzle.Count; i++)
        {
            machinesPuzzle[i].GetComponent<TurnOnOffMachines>().actived = false;
        }
        Debug.Log("Maquina incorrecta, prueba con otra");
    }
}
