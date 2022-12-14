using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkINAnim : MonoBehaviour
{
    Animator animator;

    public GameObject Player;
    public GameObject CutSceneCAM;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(WalkIN());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator WalkIN()
    {
        Player.SetActive(false);
        CutSceneCAM.SetActive(true);
        animator.SetBool("WalkIN", true);
        yield return new WaitForSeconds(4.2f);
        Player.SetActive(true);
        CutSceneCAM.SetActive(false);
        animator.SetBool("WalkIN", false);

    }
}
