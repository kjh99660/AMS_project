using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SManager2 : BgmSlider
{

    public static SManager2 instance = null;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)

            Destroy(gameObject);


    }


}
