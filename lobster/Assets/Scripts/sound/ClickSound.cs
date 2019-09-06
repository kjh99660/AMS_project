using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public static AudioClip clickSound;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick_Button()
    {
        audioSrc.PlayOneShot(clickSound);
    }


}
