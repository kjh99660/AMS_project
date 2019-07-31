using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bear_2 : MonoBehaviour
{
    protected int Bear2_hp = 20;

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
            while (transform.position.x <= -2.3f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.8f)
            {
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -5.3f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -2.5f)
            {
                transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 0.43f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= 2.0f)
            {
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.3f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -2.5f)
            {
                transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 4.5f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject, 1.0f);
        }
    }
    public IEnumerator Move_2()
    {
        {
            while (transform.position.x <= -2.28f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -16)
            {
                transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x <= 3.45f)
            {
                transform.Translate(GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -12)
            {
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= 0.49f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y >= -17.89f)
            {
                transform.Translate(0, -GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.x >= -5.31f)
            {
                transform.Translate(-GameManager.instance.Bear_2_speed * Time.deltaTime, 0, 0);
                yield return new WaitForEndOfFrame();
            }
            while (transform.position.y <= -11.1f)
            {
                transform.Translate(0, GameManager.instance.Bear_2_speed * Time.deltaTime, 0);
                yield return new WaitForEndOfFrame();
            }
            Destroy(gameObject, 1.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
