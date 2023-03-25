using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class EndSceneManager : MonoBehaviour
{
    public GameObject Made;
    public GameObject By;
    public GameObject JoelacerMixu;
    public GameObject Text1;
    public GameObject THX;
    public GameObject Text2;
    public GameObject Text3;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TextManager());

        Made.SetActive(false);
        By.SetActive(false);
        JoelacerMixu.SetActive(false);
        Text2.SetActive(false);
        Text3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator TextManager()
    {
        yield return new WaitForSeconds(2f);
        Made.SetActive(true);
        yield return new WaitForSeconds(1f);
        By.SetActive(true);
        yield return new WaitForSeconds(1f);
        JoelacerMixu.SetActive(true);
        yield return new WaitForSeconds(3f);
        Text1.SetActive(false);
        Text2.SetActive(true);
        yield return new WaitForSeconds(7f);
        Text2.SetActive(false);
        Text3.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("MainMenu");
    }
}
