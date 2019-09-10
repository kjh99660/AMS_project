using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finishgame : MonoBehaviour
{
    public float time, startTime;
    public static float limit;
    public new GameObject gameObject;
    private int playnumber = 0;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 0.0f;
        if (GameManager.instance.stage_level == 1) limit = 5f;//146f;
        if (GameManager.instance.stage_level == 2) limit = 148f;
        if (GameManager.instance.stage_level == 3) limit = 170f;
        if (GameManager.instance.stage_level == 4) limit = 240f;

        gameObject.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        startTime += Time.deltaTime;
        // Debug.Log("시간 : " + Time.time); // 주석처리
            StopGame();
            
        
    }
    
    void StopGame()
    {
        if ( startTime > limit && playnumber == 0) //승리
        {            
            Time.timeScale = 0;
            gameObject.gameObject.SetActive(true);
            
            SoundManager.PlaySound("end");
            playnumber++;
        }
        

    }


}
