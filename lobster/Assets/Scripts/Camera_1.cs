using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera_1 : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (GameManager.instance.stage_level == 2)
        {
            SceneManager.LoadScene("level2");

        }
    }
}
