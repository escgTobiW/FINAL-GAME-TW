using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAxe : MonoBehaviour
{


    Animator anim;

    public GameObject Axe;



    void Start()
    {
        anim = GetComponent<Animator>();
        Axe.SetActive(false);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) == true)
        {
            anim.SetBool("attack", true);
         
        }
        else
        {
            anim.SetBool("attack", false);
        }
    }
}
