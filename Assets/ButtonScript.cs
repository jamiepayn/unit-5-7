﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public void LoadScene (string level)
    {
        SceneManager.LoadScene(level);
    }

    public void MusicSliderChanged()
    {
        float value = GetComponent<Slider>().value;   
        print("slider=" + value);

        // store the slider's value in a permanent storage
        // Google "PlayerPrefs" to see how it works

        // permanently store the music slider volume
        PlayerPrefs.SetFloat("musicvolume",value);

        // adjust the music volume to the new level
        AudioManager.instance.SetVolume("music", value );
    }
}
