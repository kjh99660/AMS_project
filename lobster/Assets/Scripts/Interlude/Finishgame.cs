using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishgame : MonoBehaviour
{
    public float time, startTime;
    public static float limit;
    public new GameObject gameObject;
    public GameObject fail= null;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0.0f;
        time = startTime;
        limit = 60f; //몹이 다 나올때까지 걸리는 시간
        gameObject.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
       // Debug.Log("시간 : " + Time.time);  주석처리
        StopGame();
    }
    
    void StopGame()
    {
        if ( GameManager.instance.life <= 0) //패배
        {            
            Time.timeScale = 0;
            gameObject.gameObject.SetActive(true);
            fail.gameObject.SetActive(false); //다음 스테이지로 가기 비활성화
        }
        if(time > limit)//승리
        {
            Time.timeScale = 0;
            gameObject.gameObject.SetActive(true);
        }

    }


}
