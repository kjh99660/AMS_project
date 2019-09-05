using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear : MonoBehaviour
{
    protected int Bear1_hp = 120;
    public Renderer rend ;
    public float Bear_stun_time = 0.7f;//곰 스턴 시간
    public float Bear_time;
    public float speed_up;

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
        speed_up = GameManager.instance.Speed_up;
        Bear_time = 1f;
        rend = GetComponent<Renderer>();
        if (GameManager.instance.stage_level == 1)
        {
            StartCoroutine(Move());

        }
        if(GameManager.instance.stage_level == 2)
        {
            StartCoroutine(Move_2());
            
        }
        if (GameManager.instance.stage_level == 3)
        {
            
            StartCoroutine(Move_3());
        }
        if(GameManager.instance.stage_level == 4)
        {
            
            StartCoroutine(Move_4());
        }
        
    }

    public IEnumerator Move()//움직이는 경로
    {

        
            while (transform.position.x <= 19.3f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 16.9f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(-1, 1, 1);
            while (transform.position.x >= 10.5f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -0.9f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(1, 1, 1);
            while (transform.position.x <= 28.5f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 13.8f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 37.5f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -0.8f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 43.2f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject);
            GameManager.instance.life--;
        
    }
    public IEnumerator Move_3() {
        //this.GetComponent<BoxCollider>().enabled = false;
        //Invoke("EnableCol", 2); // 2초뒤에 EnableCol 이라는 함수를 호출함 
        {

            while (transform.position.x <=0)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 8.5f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            while (transform.position.y >= 15.88f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 21.3f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time * speed_up, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 26.4f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 24.9f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            transform.localScale = new Vector3(-1, 1, 1);
            while (transform.position.x >= 17.5f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= 9.94f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 11.1f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 3.36f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime  * Bear_time *speed_up, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -0.62f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 30)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject);
            GameManager.instance.life--;
        }
    }

    public IEnumerator Move_2()
    {
        {
            while (transform.position.y >= 22.92f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 13.4f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= 11)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(-1, 1, 1);
            while (transform.position.x >= 1.4f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 16.89f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(1, 1, 1);
            while (transform.position.x <= 12.97f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            while (transform.position.x <= 25.54f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 22.95f)
            {
                transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 34.6f)
            {
                transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= 13.39f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            while (transform.position.y >= 8.05f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            transform.localScale = new Vector3(-1, 1, 1);
            while (transform.position.x >= 25.29f)
            {
                transform.Translate(-GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= 5.67f)
            {
                transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject);
            GameManager.instance.life--;
        }
    }

    public IEnumerator Move_4()
    {
        while (transform.position.x <= -7.47f)
        {
            transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -13.08f)
        {
            transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }       
        while (transform.position.x <= 0.01f)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.x <= 4.44f)
        {
            transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -9.69f)
        {
            transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -4.98f)
        {
            transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= 1.69f)
        {
            transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 13.7f)
        {
            transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -6.8f)
        {
            transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -13.1f)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.y >= -16)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(0, -GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.x <= 25.53f)
        {
            transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -10.22f)
        {
            transform.Translate(0, speed_up * GameManager.instance.Bear_speed * Time.deltaTime  * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -4.15f)
        {
            transform.Translate(0, GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 28.7f)
        {
            transform.Translate(GameManager.instance.Bear_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        Destroy(gameObject);
        GameManager.instance.life--;

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
        
        if(Bear_time == 0)
        {
            Bear_stun_time -= Time.deltaTime;
        }
        if(Bear_stun_time < 0)
        {
            Bear_stun_time = 0.8f;
            Bear_time = 1f;
        }
    }
}