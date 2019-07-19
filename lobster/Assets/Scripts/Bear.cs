using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public static float Bear_speed = 3.0f;//몹 속도
    public static int stage_level = 1; //단계
    public static float Spown_term = 3.0f;//스폰되는 간격
    public static int Bear_number = 3;//몹 수


    // Start is called before the first frame update
    void Start()
    {
        if (stage_level == 1)
        {
            StartCoroutine(Move());
        }
        if (stage_level == 2)
        {
            StartCoroutine(Move_2());
        }
    }


    public IEnumerator Move()//움직이는 경로
    {
       
            transform.position = new Vector3(-10, 0.1f, 1);
            while (transform.position.x <= -2.3f)
            {
                transform.Translate(Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.8f)
            {
                transform.Translate(0, Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -5.3f)
            {
                transform.Translate(-Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -2.5f)
            {
                transform.Translate(0, -Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 0.43f)
            {
                transform.Translate(Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.0f)
            {
                transform.Translate(0, Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.3f)
            {
                transform.Translate(Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -2.5f)
            {
                transform.Translate(0, -Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 4.5f)
            {
                transform.Translate(Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(GetComponent<SpriteRenderer>());
        
    }
    public IEnumerator Move_2() {
        
            transform.position = new Vector3(-9, -13, 1);
            while (transform.position.x <= -2.28f)
            {
                transform.Translate(Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -16)
            {
                transform.Translate(0, -Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.45f)
            {
                transform.Translate(Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -12)
            {
                transform.Translate(0, Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 0.49f)
            {
                transform.Translate(-Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -17.89f)
            {
                transform.Translate(0, -Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -5.31f)
            {
                transform.Translate(-Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -11.1f)
            {
                transform.Translate(0, Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(GetComponent<SpriteRenderer>());
        
    }
    // Update is called once per frame
    //2.원 위치에서타겟 위치로 이동시 일정한 속도로 움직인다.
    //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
    void Update()
    {
        
    }
}