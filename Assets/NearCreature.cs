using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NearCreature : MonoBehaviour
{
    Animator anim;
    bool close = false;
    bool dead = false;

    public GameObject player;
    Vector3 playerPos;

    public float speed;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if ((close == true) && (Input.GetMouseButton(1) == true))
        {
            anim.SetBool("fall", true);
            dead = true;

        }

        if (close == false)
        {
            anim.SetBool("fall", false);
        }

        if (dead == false)
        {
            anim.SetBool("follow", true);
            playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
            transform.LookAt(playerPos, Vector3.up);

        }
       

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            close = true;
            anim.SetBool("shock", true);
            anim.SetBool("follow", false);

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            close = false;
            anim.SetBool("shock", false);
            anim.SetBool("follow", true);
        }


    }
}
