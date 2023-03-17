using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day2Leave : MonoBehaviour
{
    Day2Task day2task;
    public GameObject day2taskOB;

    public GameObject fadeout;
    public GameObject black;

    // Start is called before the first frame update
    void Start()
    {
        day2task = day2taskOB.GetComponent<Day2Task>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (day2task.GetDay2Done() == true && other.tag == "Player")
        {
            StartCoroutine(ToOtherDay());
        }
    }

    IEnumerator ToOtherDay()
    {
        fadeout.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        black.SetActive(true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Day3");


    }
}
