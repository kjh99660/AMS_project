using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCutToon : MonoBehaviour
{

    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }

    public void SceneChange()
    {

        SceneManager.LoadScene("CutToon");

    }
}
