using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnMainscreen : MonoBehaviour
{

    float wait = 1;


    void Start()
    {
        
    }


    void Update()
    {
      
        wait += Time.deltaTime;

        if (wait > 6)
        {
            SceneManager.LoadScene("Main menu");
        }
    }
}
