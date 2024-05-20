using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureMove : MonoBehaviour
{
    Animator anim;
    

    public GameObject player;
    Vector3 playerPos;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        anim.SetBool("follow", true);
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, playerPos, speed * Time.deltaTime);
        transform.LookAt(playerPos, Vector3.up);
      

      
    }


}
