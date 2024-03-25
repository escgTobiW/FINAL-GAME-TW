using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScript : MonoBehaviour
{
    public GameObject player;
    //public GameObject door;

    //Vector2 doorPos;


    bool near = false;


    void Start()
    {


    }

    void Update()
    {




        if ((near == true) && (Input.GetMouseButton(1) == true))
        {
       
            Application.Quit();
            //UnityEditor.EditorApplication.isPlaying = false;

        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            near = true;
         
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          
            near = false;
        }


    }
}
