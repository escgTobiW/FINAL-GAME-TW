using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{

    public GameObject Main;
    public GameObject Options;


    // Start is called before the first frame update
    void Start()
    {
     
        Options.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
     

    }



    public void Play()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        SceneManager.LoadScene("Game");
    }

    public void OptionMenu ()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Options.SetActive(true);
        Main.SetActive(false);
    }

    public void MainMenu()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Options.SetActive(false);
        Main.SetActive(true);
    }

    public void Quit()
    {
        Object.FindFirstObjectByType<AudioManagerScript>().Play("press");
        Application.Quit();
        //UnityEditor.EditorApplication.isPlaying = false;
    }


}






