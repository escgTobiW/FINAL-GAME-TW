using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FaeMove : MonoBehaviour
{
    Animator anim;
    bool close = false;
    bool dead = false;
    float wait = 1;


    public GameObject player;
    Vector3 playerPos;

    public float speed;

    public GameObject PlayerAxe;
    bool armed = false;
    Rigidbody rb;

    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        Vector3 dir = playerPos - transform.position; 

        if ((armed == true) && (close == true) && (Input.GetMouseButtonDown(0) == true))
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
            
            
            //transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);

            //rb.velocity = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
            rb.MovePosition( transform.position + dir.normalized * 0.1f );



            transform.LookAt(playerPos, Vector3.up);

        }

        if (PlayerAxe.activeSelf)
        {
            armed = true;
        }
        else
        {
            armed = false;
        }

        /*
        if (dead == true)
        {
            wait += Time.deltaTime;

        }


        if (wait > 6)
        {
            SceneManager.LoadScene("WinScreen");
        }

        */

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
