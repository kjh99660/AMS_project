using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmManager : MonoBehaviour
{
    public static AudioClip mainTheme;
    public static AudioClip level1Theme, level2Theme, level3Theme, level4Theme;

    public static AudioClip bossTheme;

    static AudioSource audioSrc;

    private void Start()
    {

        mainTheme = Resources.Load<AudioClip>("main");
        
        bossTheme = Resources.Load<AudioClip>("boss");

        level1Theme =  Resources.Load<AudioClip>("lev1");
        level2Theme = Resources.Load<AudioClip>("lev2");
        level3Theme = Resources.Load<AudioClip>("lev3");
        level4Theme = Resources.Load<AudioClip>("lev4");

        audioSrc = GetComponent<AudioSource>();

    }

    public static void PlaySound(string clip)
    {


        switch (clip)
        {
            case "main":
                audioSrc.PlayOneShot(mainTheme);
                break;
            case "boss":
                audioSrc.PlayOneShot(bossTheme);
                break;
            case "lev1":
                audioSrc.PlayOneShot(level1Theme);              
                break;
            case "lev2":
                audioSrc.PlayOneShot(level2Theme);
                break;
            case "lev3":
                audioSrc.PlayOneShot(level3Theme);
                break;
            case "lev4":
                audioSrc.PlayOneShot(level4Theme);
                break;
        }
    }

}
