﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toSoundSet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }

    public void OnClick_SoundButton()
    {

           gameObject.SetActive(true);

    }
   
}
