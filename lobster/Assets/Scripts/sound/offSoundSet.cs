using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class offSoundSet : MonoBehaviour
{
    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }
    public void OnClickButton_X()
    {

        gameObject.SetActive(false);

    }

}
