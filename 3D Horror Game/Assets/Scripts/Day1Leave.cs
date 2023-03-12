using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Day1Leave : MonoBehaviour
{
    Day1Task day1task;
    public GameObject Day1TaskOB;

    public GameObject fadeout;
    public GameObject black;

    // Start is called before the first frame update
    void Start()
    {
        day1task = Day1TaskOB.GetComponent<Day1Task>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (day1task.GetLeave3() == true && other.tag == "Player")
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
        SceneManager.LoadScene("Day2");


    }
}
