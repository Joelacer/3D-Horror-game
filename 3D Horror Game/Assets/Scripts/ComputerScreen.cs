using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScreen : MonoBehaviour
{

    PlayerLook playerLook;
    GameObject playerCamera;
    PlayerMove playerMove;
    ComputerCamera playerOnComputer;
    

    public GameObject ComputerCanvas;



    // Start is called before the first frame update
    void Awake()
    {
        ComputerCanvas.SetActive(false);
        playerLook = GameObject.Find("Main Camera").GetComponent<PlayerLook>();
        playerCamera = GameObject.Find("Main Camera");
        playerMove = GameObject.Find("Player").GetComponent<PlayerMove>();
        playerOnComputer = GameObject.Find("Player").GetComponent<ComputerCamera>();
    }

    public void ExitComputer()
    {
        ComputerCanvas.SetActive(false);
        playerLook.canLook = true;
        playerMove.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        playerOnComputer.onComputer = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
