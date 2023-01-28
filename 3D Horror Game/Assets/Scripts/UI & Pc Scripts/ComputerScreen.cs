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
    public GameObject ColorGame;
    public GameObject SortGame;
    public GameObject FixGame;

    bool Startcolorgame = false;
    bool SoundStartPlayed = false;
    //bool StartSortgame = false;


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
        ColorGame.SetActive(false);
        playerLook.canLook = true;
        playerMove.canMove = true;
        Cursor.lockState = CursorLockMode.Locked;
        playerOnComputer.onComputer = false;
    }

    public void OpenColorGame()
    {
        ColorGame.SetActive(true);
        Startcolorgame = true;
    }

    public void OpenSortGame()
    {
        SortGame.SetActive(true);
        //StartSortgame = true;
    }

    public void OpenFixGame()
    {
       
        FixGame.SetActive(true);  
    }

    public void FixgameVoiceline()
    {
       if (SoundStartPlayed == false)
        {
            SoundStartPlayed = true;
            Sound.PlaySound("Lucas_FixGame_Start");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetStartColorgame()
    {
        return Startcolorgame;
    }
}
