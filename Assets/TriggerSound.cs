using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 using UnityEngine.EventSystems;
using UnityEngine.Audio;

public class TriggerSound : MonoBehaviour, IPointerEnterHandler
{

    public AudioMixer audioMixer;

    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        print("entered");
        AudioManager.instance.Play("menu hover");
    }

 
}
