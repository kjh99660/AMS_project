using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //public static SoundManager instance = null;
    public static AudioClip rab1Sound, rab2Sound, rab3Sound, bearDeathSound;
    public static AudioClip endTheme;
    public static AudioClip clickSound;

    static AudioSource audioSrc;

    private void Start()
    {

        rab1Sound = Resources.Load<AudioClip>("rab1");
        rab2Sound = Resources.Load<AudioClip>("rab2");
        rab3Sound = Resources.Load<AudioClip>("rab3");
        bearDeathSound = Resources.Load<AudioClip>("bearDeath");
        clickSound = Resources.Load<AudioClip>("click");

        endTheme = Resources.Load<AudioClip>("end");

        audioSrc = GetComponent<AudioSource>();

    }

    //초기화
    //void Awake()
    //{
    //    if (instance == null)
    //        instance = this;
    //    else if (instance != this)
    //    {
    //        Destroy(gameObject);
    //    }
    //    DontDestroyOnLoad(gameObject);
    //}



    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "rab1":
                audioSrc.PlayOneShot(rab1Sound);
                break;
            case "rab2":
                audioSrc.PlayOneShot(rab2Sound);
                break;
            case "rab3":
                audioSrc.PlayOneShot(rab3Sound);
                break;
            case "bearDeath":
                audioSrc.PlayOneShot(bearDeathSound);
                break;
            case "click":
                audioSrc.PlayOneShot(clickSound);
                break;
            case "end":
                audioSrc.PlayOneShot(endTheme);
                break;



        }
    }


}
