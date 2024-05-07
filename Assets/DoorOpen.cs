using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        
    }




    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("open", true);

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("open", false);

        }


    }
}


