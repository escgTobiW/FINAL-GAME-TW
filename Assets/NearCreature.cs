using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NearCreature : MonoBehaviour
{
    Animator anim;
    bool close = false;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if ((close == true) && (Input.GetMouseButton(1) == true))
        {
            anim.SetBool("fall", true);


        }

        if (close == false)
        {
            anim.SetBool("fall", false);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            close = true;
            anim.SetBool("shock", true);
          
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            close = false;
            anim.SetBool("shock", false);

        }


    }
}
