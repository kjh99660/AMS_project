using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BgmManager : MonoBehaviour
{
    public static AudioClip mainTheme, bossTheme;
    public static AudioClip level12Theme, level3Theme, level4Theme;
    public static AudioClip endTheme;

    static AudioSource audioSrc2;
    static AudioSource audioSrc3;

    private void Start()
    {

        mainTheme = Resources.Load<AudioClip>("main");       
        bossTheme = Resources.Load<AudioClip>("boss");
        level12Theme =  Resources.Load<AudioClip>("level12");
        level3Theme = Resources.Load<AudioClip>("level3");
        level4Theme = Resources.Load<AudioClip>("level4");

        endTheme = Resources.Load<AudioClip>("end");

        audioSrc2 = GetComponent<AudioSource>();
        audioSrc3 = GetComponent<AudioSource>();

    }

    public static void PlaySound2(string clip)
    {

        switch (clip)
        {
            case "main":
                audioSrc2.PlayOneShot(mainTheme);
                break;
            case "boss":
                audioSrc2.PlayOneShot(bossTheme);
                break;
            case "level12":
                audioSrc2.PlayOneShot(level12Theme);
                break;
            case "level3":
                audioSrc2.PlayOneShot(level3Theme);
                break;
            case "level4":
                audioSrc2.PlayOneShot(level4Theme);
                break;
            case "end":
                audioSrc3.PlayOneShot(endTheme);
                break;

        }
    }


    public static void StopSound()
    {
        audioSrc2.Stop();
    }

}
