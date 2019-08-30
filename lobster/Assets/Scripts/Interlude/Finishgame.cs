using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishgame : MonoBehaviour
{
    public float time, startTime;
    public static float limit;
    public new GameObject gameObject;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0.0f;
        time = startTime;
        limit = 60f;
        gameObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
       // Debug.Log("시간 : " + Time.time); 느려저서 주석처리
        StopGame();
    }

    void StopGame()
    {
        if (time > limit)
        {            
            Time.timeScale = 0;
            gameObject.gameObject.SetActive(true);
        }

    }


}
