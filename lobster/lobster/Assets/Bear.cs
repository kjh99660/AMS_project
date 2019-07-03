using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    public float Bear_speed = 3.0f;//몹 속도

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());    
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

    // Update is called once per frame
    //2.원 위치에서타겟 위치로 이동시 일정한 속도로 움직인다.
    //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
    void Update()
    {
        

    }
}