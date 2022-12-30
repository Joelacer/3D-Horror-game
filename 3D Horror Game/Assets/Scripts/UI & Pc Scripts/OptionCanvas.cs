using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionCanvas : MonoBehaviour
{
    bool First = false;

    public GameObject ALL;

    public void Hello()
    {
        Sound.PlaySound("CanIHelpU");
        ALL.SetActive(false);
        First = true;
    }

    public void Leave()
    {
        ALL.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public bool GetFirst()
    { 
        return First;
    }









    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
