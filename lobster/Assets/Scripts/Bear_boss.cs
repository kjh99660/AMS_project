using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_boss : MonoBehaviour
{
    protected int Bear_boss_hp = 3200;
    public Renderer rend;
    public float Bear_stun_time = 0.8f;//곰 스턴 시간
    public float Bear_time;
    private float speed_up;

    public int Bear_boss_HP
    {
        get
        {
            return Bear_boss_hp;
        }
        set
        {
            Bear_boss_hp = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        speed_up = GameManager.instance.Speed_up;
        Bear_time = 1f;
        rend = GetComponent<Renderer>();
        if (GameManager.instance.stage_level == 4)
        {
            StartCoroutine(Move_4());
        }
    }

    public IEnumerator Move_4()
    {
        while (transform.position.x <= -7.47f)
        {
            transform.Translate(GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -13.08f)
        {
            transform.Translate(0, -GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 0.01f)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.x <= 4.44f)
        {
            transform.Translate(GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -9.69f)
        {
            transform.Translate(0, GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -4.98f)
        {
            transform.Translate(0, GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= 1.69f)
        {
            transform.Translate(0, GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 13.7f)
        {
            transform.Translate(GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -6.8f)
        {
            transform.Translate(0, -GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y >= -13.1f)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(0, -GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.y >= -16)
        {
            rend.enabled = false;
            this.GetComponent<BoxCollider2D>().enabled = false;
            transform.Translate(0, -GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
            Invoke("EnableCol", 0);
            rend.enabled = true;
        }
        while (transform.position.x <= 25.53f)
        {
            transform.Translate(GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -10.22f)
        {
            transform.Translate(0, speed_up * GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.y <= -4.15f)
        {
            transform.Translate(0, GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0);
            yield return new WaitForEndOfFrame();
        }
        while (transform.position.x <= 28.7f)
        {
            transform.Translate(GameManager.instance.Bear_b_speed * Time.deltaTime * Bear_time, 0, 0);
            yield return new WaitForEndOfFrame();
        }
        Destroy(gameObject);
        GameManager.instance.life -= 100;

    }
    void EnableCol()
    {
        this.GetComponent<BoxCollider2D>().enabled = true; // 자기자신의 박스콜라이더를 켬 
    }

    // Update is called once per frame
    void Update()
    {

        if (Bear_time == 0)
        {
            Bear_stun_time -= Time.deltaTime;
        }
        if (Bear_stun_time < 0)
        {
            Bear_stun_time = 0.8f;
            Bear_time = 1f;
        }
        if (Bear_boss_hp <= 0)
        {
            SoundManager.PlaySound("bearDeath");
        }

    }
}

