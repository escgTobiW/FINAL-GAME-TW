using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject player;
    //public GameObject door;

    //Vector2 doorPos;


    bool openable = false;


    void Start()
    {

        Object.FindFirstObjectByType<AudioManagerScript>().Play("Door");
    }

    void Update()
    {

        //print("door=" + openable);
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;

        //door = GameObject.Find("door");
        // doorPos = new Vector2(door.transform.position.x, door.transform.position.y);



        if ((openable == true) && (Input.GetMouseButton(1) == true))
        {
            //print("mouse pressed");
            //print(sceneName);
            //FindObjectOfType<AudioManagerScript>().Play("Door");
            Object.FindFirstObjectByType<AudioManagerScript>().Play("Door");
            if (sceneName == "Outside")
            {
                SceneManager.LoadScene("Inside");
                /*door = GameObject.Find("door");
                doorPos = new Vector2(door.transform.position.x, door.transform.position.y);
                player.transform.position = doorPos;*/




            }
            else if (sceneName == "Inside")
            {
                SceneManager.LoadScene("Outside");
                // door = GameObject.Find("door");
                // doorPos = new Vector2(door.transform.position.x, door.transform.position.y);
                // player.transform.position = doorPos;
               

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
