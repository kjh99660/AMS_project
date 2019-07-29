using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public int first = 1;
    
    protected int Bear1_hp = 10;
   
    public int Bear1_HP
    {
        get
        {
            return Bear1_hp;
        }
        set
        {
            Bear1_hp = value;
            if(Bear1_HP <= 0)
            {
                GameManager.instance.Money += 20;
                Debug.Log("잡음");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        if (GameManager.instance.stage_level == 1)
        {
            StartCoroutine(Move());

        }
        if (GameManager.instance.stage_level == 2)
        {
            StartCoroutine(Move_2());
        }
    }

    public IEnumerator Move()//움직이는 경로
    {
        if(first == 1)
        {
            while (transform.position.x < 1000)
            {
                transform.Translate(0.01f * Time.deltaTime, 0, 0);
                
            }
            first--;
        }
       
            
            while (transform.position.x <= -2.3f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.8f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -5.3f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -2.5f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 0.43f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.0f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.3f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -2.5f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 4.5f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject, 1.0f);

    }
    public IEnumerator Move_2() {
        
            transform.position = new Vector3(-9, -13, 1);
            while (transform.position.x <= -2.28f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -16)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.45f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -12)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 0.49f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -17.89f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -5.31f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -11.1f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject,1.0f);
        
    }
    // Update is called once per frame
    //2.원 위치에서타겟 위치로 이동시 일정한 속도로 움직인다.
    //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
    void Update()
    {
        
    }
}