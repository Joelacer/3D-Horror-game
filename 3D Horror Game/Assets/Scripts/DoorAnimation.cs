using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimation : MonoBehaviour
{
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(StartCooldown());
            }
            
        }
    }

    public IEnumerator StartCooldown()
    {
        animator.SetBool("isOpening", true);
        yield return new WaitForSeconds(5);
        animator.SetBool("isOpening", false);
    }
}
