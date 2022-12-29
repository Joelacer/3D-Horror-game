using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class personTalk : MonoBehaviour
{
    public GameObject Player;
    bool used = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player && Input.GetKey(KeyCode.E) && used == false)
        {
            Sound.PlaySound("Broom");
            used = true;
        }
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
