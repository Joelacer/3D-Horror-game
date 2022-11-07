using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialouge : MonoBehaviour
{
    public TextMeshProUGUI textcomponent;
    public string[] lines;
    public float textSpeed;
    public GameObject dialogebox;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        textcomponent.text = string.Empty;
        stratDialouge();

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (textcomponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textcomponent.text = lines[index];
            }
        }
    }

    void stratDialouge()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textcomponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < lines.Length -1)
        {
            index++;
            textcomponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            dialogebox.SetActive(false);
        }
    }
}
