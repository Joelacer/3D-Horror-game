using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject NewspaperOB;
    public GameObject music;
    public GameObject sound;

    public GameObject AboutScreen;

    public void office()
    {
        //SceneManager.LoadScene("Office");
        StartCoroutine(NewsPaper());
    }

    public void AboutON()
    {
        AboutScreen.SetActive(true);
    }
    public void AboutOFF()
    {
        AboutScreen.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator NewsPaper()
    {
        sound.SetActive(true);
        //Sound.PlaySound("newsPaperSound");
        music.SetActive(false);
        NewspaperOB.SetActive(true);
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Day1");
    }

    // Start is called before the first frame update
    void Start()
    {
        NewspaperOB.SetActive(false);
        AboutScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
