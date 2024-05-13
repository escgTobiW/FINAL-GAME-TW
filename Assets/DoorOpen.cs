using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    Animator anim;
    bool openable = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if ((openable == true) && (Input.GetMouseButton(1) == true))
        {

            if (anim.GetBool("open") == false)
            {
                anim.SetBool("open", true);

            }
            else
            {

                anim.SetBool("open", false);

            }
              


        }

    }




    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openable = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            openable = false;
           

        }


    }
}


