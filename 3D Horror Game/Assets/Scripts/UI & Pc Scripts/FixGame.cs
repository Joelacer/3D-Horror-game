using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixGame : MonoBehaviour
{
    public GameObject Err1;
    public GameObject Err2;
    public GameObject Err3;

    public GameObject Fixing1;
    public GameObject Fixing2;
    public GameObject Fixing3;

    public GameObject Fixed1;
    public GameObject Fixed2;
    public GameObject Fixed3;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void File1()
    {
        StartCoroutine(file1());
    }

    IEnumerator file1()
    {
        Err1.SetActive(false);
        Fixing1.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing1.SetActive(false);
        Fixed1.SetActive(true);

    }

    public void File2()
    {
        StartCoroutine(file2());
    }

    IEnumerator file2()
    {
        Err2.SetActive(false);
        Fixing2.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing2.SetActive(false);
        Fixed2.SetActive(true);

    }

    public void File3()
    {
        StartCoroutine(file3());
    }

    IEnumerator file3()
    {
        Err3.SetActive(false);
        Fixing3.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing3.SetActive(false);
        Fixed3.SetActive(true);

    }
}
