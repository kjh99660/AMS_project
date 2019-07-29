using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bgmSlider : MonoBehaviour
{
    public Slider Volume;
    public AudioSource audio;

    private float Vol = 1f;

    private void Start()
    {
        Vol = PlayerPrefs.GetFloat("backvol", 1f);
        Volume.value = Vol;
        audio.volume = Volume.value;

    }

    void Update()
    {
        audio.volume = Volume.value;


    }


}
