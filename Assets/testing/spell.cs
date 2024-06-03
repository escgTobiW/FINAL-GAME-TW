using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spell : MonoBehaviour
{


    
    public GameObject player;
    Vector3 playerPos;

    public float speed;

    bool On = true;
   


   

    void Start()
    {
  
    }

  
    void Update()
    {



        if (Input.GetMouseButtonDown(1) == true)
        {
            On = !On;
        }

        if (On == true)
        {
            playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
            //transform.LookAt(playerPos, Vector3.up);
        }




    }
}
