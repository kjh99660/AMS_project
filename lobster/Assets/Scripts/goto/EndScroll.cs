using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScroll : MonoBehaviour
{
    public float time, startTime;
    public static float limit;


    // Start is called before the first frame update
    void Start()
    {
        startTime = 0.0f;
        time = startTime;
        limit = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        GoStartScene();
    }

    void GoStartScene()
    {
        if (time > limit)
        {
            Time.timeScale = 0;
            SceneManager.LoadScene("StartScene");
        }

    }
}
