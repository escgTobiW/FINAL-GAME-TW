using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvScript : MonoBehaviour
{
    Animator anim;
    bool switchable = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if ((switchable == true) && (Input.GetMouseButtonDown(1) == true))
        {

            if (anim.GetBool("on") == false)
            {
                anim.SetBool("on", true);

            }
            else
            {

                anim.SetBool("on", false);

            }



        }

    }




    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switchable = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            switchable = false;


        }


    }
}
