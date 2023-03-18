using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
    public GameObject ScareCamera;
    public GameObject Player;
    public GameObject BossJumpscare;
    public GameObject Black;
    public GameObject Canvases;

    bool PlayOnce = false;

    Day3Task day3task;
    public GameObject ShowTask;

    // Start is called before the first frame update
    void Start()
    {
        ScareCamera.SetActive(false);
        BossJumpscare.SetActive(false);
        day3task = ShowTask.GetComponent<Day3Task>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKey(KeyCode.E) && day3task.GetJumpscare() == true)
        {
            ScareCamera.SetActive(true);
            Player.SetActive(false);
            Canvases.SetActive(false);
            StartCoroutine(jumpscare());

        }

    }

    IEnumerator jumpscare()
    {
        if (PlayOnce == false)
        {

            PlayOnce = true;

            Black.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            Black.SetActive(false);
            yield return new WaitForSeconds(0.4f);
            Black.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            Black.SetActive(false);
            Black.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            Black.SetActive(false);
            yield return new WaitForSeconds(0.3f);
            Black.SetActive(true);
            yield return new WaitForSeconds(0.3f);
            Black.SetActive(false);
            BossJumpscare.SetActive(true);
            yield return new WaitForSeconds(3f);
            Black.SetActive(true);
            
        }
    }
}
