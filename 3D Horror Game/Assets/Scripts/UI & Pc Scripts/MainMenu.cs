using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject NewspaperOB;
    public GameObject music;
    public GameObject sound;

    public void office()
    {
        //SceneManager.LoadScene("Office");
        StartCoroutine(NewsPaper());
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
        SceneManager.LoadScene("Office");
    }

    // Start is called before the first frame update
    void Start()
    {
        NewspaperOB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
