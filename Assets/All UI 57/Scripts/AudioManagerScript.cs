using UnityEngine.Audio;
using System;
using UnityEngine;
//using static Unity.VisualScripting.Member;

public class AudioManagerScript : MonoBehaviour
{



    public Sound[] soundList;

    public static AudioManagerScript instance;


    void Awake()
    {
        if (instance == null)
        {

            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);

        foreach (Sound s in soundList)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.outputAudioMixerGroup = AmixSFX;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }

        
    }

    public AudioMixerGroup AmixSFX;
   

    public void Play(string name)
    {
       Sound s = Array.Find(soundList, sound => sound.name == name);

        if (s == null)
        {
            return;
        }

        s.source.Play();
    }
        
    








    void Start()
    {
        
    }


   // array[2] = 2;





    void Update()
    {
        
    }
}
