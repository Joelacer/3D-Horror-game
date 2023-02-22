using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkINAnim : MonoBehaviour
{
    Animator animator;

    public GameObject Player;
    public GameObject CutSceneCAM;

    bool CanSkip;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(WalkIN());
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CanSkip == true && Input.GetKey(KeyCode.Space))
        {
            CanSkip = false;
            StopCoroutine(WalkIN());
            Player.SetActive(true);
            CutSceneCAM.SetActive(false);
            animator.SetBool("WalkIN", false);
        }
    }

    IEnumerator WalkIN()
    {
        CanSkip = true;
        Player.SetActive(false);
        CutSceneCAM.SetActive(true);
        animator.SetBool("WalkIN", true);
        yield return new WaitForSeconds(7f);
        Sound.PlaySound("bossStart");
        yield return new WaitForSeconds(10f);
        Player.SetActive(true);
        CutSceneCAM.SetActive(false);
        animator.SetBool("WalkIN", false);

    }
}
