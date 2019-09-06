using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class To4 : MonoBehaviour
{

    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }


    // Start is called before the first frame update
    public void SceneChange()
    {

        SceneManager.LoadScene("level4");

    }

}
