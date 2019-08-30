using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect : Spawner
{
    public Slider Volume2;
    public AudioSource audio_effect1;

    public AudioClip hitsound;
    public AudioClip deathsound;


    private float Vol2 = 0.5f;

    public static int a = 1;
    public int count2 = 0;

    // Start is called before the first frame update
    void Start()
    {
 //       audio_effect1 = GetComponent<AudioSource>();
        Volume2.value = Vol2;
        audio_effect1.volume = Volume2.value;

    }

    // Update is called once per frame
    void Update()
    {

    }

    void DeathSound()
    {
        count2 = a;
        if (count2 == count)
        {
            audio_effect1.PlayOneShot(deathsound);
            count2++;
        }
    }

    void HitSound()
    {
 
    }


    public void Slider2()
    {
        audio_effect1.volume = Volume2.value;
        Vol2 = Volume2.value;
        PlayerPrefs.SetFloat("Vol", Vol2);
    }


}
