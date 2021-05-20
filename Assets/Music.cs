using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class Music : MonoBehaviour
{
    

    

    public AudioMixer audioMixer;

    private static Music instance;

 

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    void Awake ()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }

        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }

  


}
