using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkINAnim : MonoBehaviour
{
    Animator animator;

    public GameObject Player;
    public GameObject CutSceneCAM;
    public GameObject BossStart;

    public GameObject FadeIN;
    public GameObject FadeOut;
    public GameObject Black;

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
        FadeIN.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        FadeIN.SetActive(false);

        CanSkip = true;
        Player.SetActive(false);
        CutSceneCAM.SetActive(true);
        animator.SetBool("WalkIN", true);
        yield return new WaitForSeconds(3f);
        Sound.PlaySound("bossStart");
        yield return new WaitForSeconds(10f);

        FadeOut.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        Black.SetActive(true);
        FadeOut.SetActive(false);

        //Black.SetActive(true);
        BossStart.SetActive(false);
        yield return new WaitForSeconds(1f);
        
        FadeIN.SetActive(true);
        Black.SetActive(false);
        animator.SetBool("WalkIN", false);
        Player.SetActive(true);
        FadeIN.SetActive(false);
        CutSceneCAM.SetActive(false);
        

        //Player.SetActive(true);
        //CutSceneCAM.SetActive(false);
        //animator.SetBool("WalkIN", false);

    }
}
