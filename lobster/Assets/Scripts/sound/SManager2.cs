using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SManager2 : bgmSlider
{
    private bool jud = true;

    public void StopMusic()
    {
        if (jud)
        {
            Audio.Pause();
        }
        else
        {
            Audio.UnPause();
        }

    }

}
