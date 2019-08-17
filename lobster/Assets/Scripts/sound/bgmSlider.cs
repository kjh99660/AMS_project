using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmSlider : MonoBehaviour
{
    public Slider Volume;
    public AudioSource audio;

    private float Vol = 1f;

    private void Start()
    {
     //   Vol = PlayerPrefs.GetFloat("backvol", 1f);
        Volume.value = Vol;
        audio.volume = Volume.value;

    }

    void Update()
    {
        SoundSlider();

    }

    public void SoundSlider()
    {
        audio.volume = Volume.value;//여기 계속 에러나요

        Vol = Volume.value;
        PlayerPrefs.SetFloat("Vol", Vol);
    }


}
