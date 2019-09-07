using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backToStart : MonoBehaviour
{

    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }


    public void ChangeScene()
    {

        SceneManager.LoadScene("startScene");

    }

}
