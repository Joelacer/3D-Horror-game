using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class personTalk : MonoBehaviour
{
    public GameObject Player;
    public GameObject Option;
    public GameObject First;

    OptionCanvas option;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == Player && Input.GetKey(KeyCode.E))
        {
            //Sound.PlaySound("Broom");
            Option.SetActive(true);
            Cursor.lockState = CursorLockMode.Confined;
            
        }

        if (other.gameObject == Player && option.GetFirst() == true)
        {
            //Option.SetActive(true);
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1);
        Option.SetActive(true);
    }









    // Start is called before the first frame update
    void Awake()
    {
        Option.SetActive(false);
        option = GameObject.Find("CanvasOption").GetComponent<OptionCanvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if(option.GetFirst() == true)
        {
            First.SetActive(false);
        }
    }
}
