using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AxeScript : MonoBehaviour
{
   
    bool reach = false;


    public GameObject PlayerAxe;


    void Start()
    {
    
    }


    void Update()
    {
        if ((reach == true) && (Input.GetMouseButtonDown(1) == true))
        {
            //pick up axe
            PlayerAxe.SetActive(true);
            Destroy(gameObject);

        }

    }




    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            reach = true;

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            reach = false;


        }


    }
}
