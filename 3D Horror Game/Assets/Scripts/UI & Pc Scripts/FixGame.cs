using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixGame : MonoBehaviour
{
    public GameObject Err1;
    public GameObject Err2;
    public GameObject Err3;
    public GameObject Err4;
    public GameObject Err5;
    public GameObject Err6;
    public GameObject Err7;

    public GameObject Fixing1;
    public GameObject Fixing2;
    public GameObject Fixing3;
    public GameObject Fixing4;
    public GameObject Fixing5;
    public GameObject Fixing6;
    public GameObject Fixing7;

    public GameObject Fixed1;
    public GameObject Fixed2;
    public GameObject Fixed3;
    public GameObject Fixed4;
    public GameObject Fixed5;
    public GameObject Fixed6;
    public GameObject Fixed7;

    public GameObject Phase2;
    public GameObject Phase3;

   public float ToPhase3 = 0f;
   public float ToWin = 0f;

    bool CanDo1 = true;
    bool CanDo2 = true;
    bool CanDo3 = true;
    bool CanDo4 = true;
    bool CanDo5 = true;
    bool CanDo6 = true;
    bool CanDo7 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ToPhase3 == 2)
        {
            Phase3.SetActive(true);
        }

        if (ToWin == 4)
        {
            gameObject.SetActive(false);
        }
    }

    public void Exit()
    {
        gameObject.SetActive(false);
    }

    public void File1()
    {
        if (CanDo1 == true)
        {
            StartCoroutine(file1());
        }
    }

    IEnumerator file1()
    {
        Err1.SetActive(false);
        Fixing1.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing1.SetActive(false);
        Fixed1.SetActive(true);
        Phase2.SetActive(true);
        CanDo1 = false;

    }

    //Phase2

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
        ToPhase3 += 1;

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
        ToPhase3 += 1;

    }

    public void File4()
    {
        StartCoroutine(file4());
    }

    IEnumerator file4()
    {
        Err4.SetActive(false);
        Fixing4.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing4.SetActive(false);
        Fixed4.SetActive(true);
        ToWin += 1;

    }

    public void File5()
    {
        StartCoroutine(file5());
    }

    IEnumerator file5()
    {
        Err5.SetActive(false);
        Fixing5.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing5.SetActive(false);
        Fixed5.SetActive(true);
        ToWin += 1;

    }

    public void File6()
    {
        StartCoroutine(file6());
    }

    IEnumerator file6()
    {
        Err6.SetActive(false);
        Fixing6.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing6.SetActive(false);
        Fixed6.SetActive(true);
        ToWin += 1;

    }

    public void File7()
    {
        StartCoroutine(file7());
    }

    IEnumerator file7()
    {
        Err7.SetActive(false);
        Fixing7.SetActive(true);
        yield return new WaitForSeconds(4);
        Fixing7.SetActive(false);
        Fixed7.SetActive(true);
        ToWin += 1;

    }
}
