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
        if(GameManager.instance.stage_level == 1) limit = 146f;
        if(GameManager.instance.stage_level == 2) limit = 148f;
        if(GameManager.instance.stage_level == 3) limit = 227f;

        gameObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        Debug.Log("시간 : " + Time.time); // 주석처리
        StopGame();
    }
    
    void StopGame()
    {
        if ( startTime > limit) //승리
        {            
            Time.timeScale = 0;
            gameObject.gameObject.SetActive(true);
          
        }
        

    }


}
