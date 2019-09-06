using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class toBook : MonoBehaviour
{

    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }


    public void SceneChange()
    {

        SceneManager.LoadScene("Book");

    }


}
