using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playeranim : MonoBehaviour
{


    Animator anim;

   
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Creature"))
        {
            print("should be dead");
            anim.SetBool("dead", true);

        }

    }
}
