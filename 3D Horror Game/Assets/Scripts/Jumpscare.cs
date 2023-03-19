using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{
    public GameObject ScareCamera;
    public GameObject Player;
    public GameObject BossJumpscare;
    public GameObject Black;
    public GameObject Canvases;

    bool PlayOnce = false;
    bool HungryOnce = false;
    bool MonsterOnce = false;

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
            if (HungryOnce == false)
            {
                HungryOnce = true;
                Sound.PlaySound("IamHungry");
            }
            yield return new WaitForSeconds(4f);
            Black.SetActive(false);
            yield return new WaitForSeconds(1f);
            Black.SetActive(true);
            yield return new WaitForSeconds(1f);
            Black.SetActive(false);
            yield return new WaitForSeconds(1f);
            Black.SetActive(true);
            yield return new WaitForSeconds(1f);
            Black.SetActive(false);
            BossJumpscare.SetActive(true);
            if (MonsterOnce == false)
            {
                MonsterOnce = true;
                Sound.PlaySound("MonsterSound");
            }
            yield return new WaitForSeconds(3f);
            Black.SetActive(true);
            yield return new WaitForSeconds(3f);
            SceneManager.LoadScene("EndScene");
            
        }
    }
}
