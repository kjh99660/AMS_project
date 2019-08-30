using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class bgmSlider : MonoBehaviour
{
    public Slider Volume;
    public AudioSource Audio;
    private float Vol = 1f;
    
    private void Start()
    {
  //      Vol = PlayerPrefs.GetFloat("backvol", 1f);
  //      Volume.value = Vol;
    //    Audio.volume = Volume.value;

    }

    void Update()
    {
        SoundSlider();

    }

    public void SoundSlider()
    {
        
       // Audio.volume = Volume.value;
       // Vol = Volume.value;
        PlayerPrefs.SetFloat("Vol", Vol);
    }



}
