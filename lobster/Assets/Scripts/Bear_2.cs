using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_2 : MonoBehaviour
{
    protected int Bear2_hp = 20;
    public Renderer rend;

    public int Bear2_HP
    {
        get
        {
            return Bear2_hp;
        }
        set
        {
            Bear2_hp = value;
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
        if (GameManager.instance.stage_level == 3)
        {
            StartCoroutine(Move_3());
        }

    }
    public IEnumerator Move()//움직이는 경로
    {
        while (transform.position.x <= 19.3f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= 16.9f)
        {
            transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = new Vector3(-1, 1, 1);
        while (transform.position.x >= 10.5f)
        {
            transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= 10.6f)
        {
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = new Vector3(1, 1, 1);
        while (transform.position.x <= 28.5f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= 13.8f)
        {
            transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 37.1f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -0.8f)
        {
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 43.2f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        Destroy(gameObject);
        GameManager.instance.life--;
    }
    public IEnumerator Move_2()
    {
        while (transform.position.y >= 22.92f)
        {
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 13.4f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= 11)
        {
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = new Vector3(-1, 1, 1);
        while (transform.position.x >= 1.4f)
        {
            transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= 16.89f)
        {
            transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = new Vector3(1, 1, 1);
        while (transform.position.x <= 12.97f)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.x <= 25.54f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= 22.95f)
        {
            transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 34.6f)
        {
            transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= 13.39f)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.y >= 8.05f)
        {
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        transform.localScale = new Vector3(-1, 1, 1);
        while (transform.position.x >= 25.29f)
        {
            transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= 5.67f)
        {
            transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
        Destroy(gameObject);
        GameManager.instance.life--;

    }
    public IEnumerator Move_3()
    {
        {

            while (transform.position.x <= 0)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 8.5f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            while (transform.position.y >= 15.88f)
            {
                transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 21.3f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime * 1.3f, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 26.4f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 18.18f)
            {
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 24.9f)
            {
                rend.enabled = false;
                this.GetComponent<BoxCollider2D>().enabled = false;
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
                Invoke("EnableCol", 0);
                rend.enabled = true;
            }
            transform.localScale = new Vector3(-1, 1, 1);
            while (transform.position.x >= 17.5f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= 7)
            {
                transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 11.1f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 3.36f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime * 1.3f, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -0.62f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 25.34f)
            {
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
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
    void Update()
    {
        
    }
}
