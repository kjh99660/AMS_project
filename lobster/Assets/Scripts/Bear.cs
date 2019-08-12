using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    protected int Bear1_hp = 10;
    public Renderer rend ;
   
    public int Bear1_HP
    {
        get
        {
            return Bear1_hp;
        }
        set
        {
            Bear1_hp = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
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


        {


            while (transform.position.x <= -1.8f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.5f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
            while (transform.position.x >= -5.3f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -3.3f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
            while (transform.position.x <= 1.6f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 1.5f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 5.3f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -3.2f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 8.5f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject);
            GameManager.instance.life--;
        }
    }
    public IEnumerator Move_2() {
        //this.GetComponent<BoxCollider>().enabled = false;
        //Invoke("EnableCol", 2); // 2초뒤에 EnableCol 이라는 함수를 호출함 
        {

            while (transform.position.x <= -4.9f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= -2.29f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            while (transform.position.y >= -16)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 1.72f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * 1.3f, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.45f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -14.5f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -12)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
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
            while (transform.position.x >= -1.5f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -4)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * 1.3f, 0, 0);
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
            Destroy(gameObject);
            GameManager.instance.life--;
        }
    }
    void EnableCol()
    {
        this.GetComponent<BoxCollider2D>().enabled = true; // 자기자신의 박스콜라이더를 켬 
    }
    // Update is called once per frame
    //2.원 위치에서타겟 위치로 이동시 일정한 속도로 움직인다.
    //transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed* Time.deltaTime);
    void Update()
    {
    }
}