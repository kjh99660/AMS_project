using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class to2 : MonoBehaviour
{
    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }

    public void SceneChange()
    {

        SceneManager.LoadScene("level2");
        

    }
}
