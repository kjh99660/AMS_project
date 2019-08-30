using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    //애니메이션 구현 추가
    public Animator animator;
    public Transform spriteTr;  //유닛이 통채로 좌우반전 되는 게 아니라 스프라이트만 반전돼야 하므로 스프라이트 오브젝트의 Transform을 따로 건드림.
    private Transform rabbitTr;  //유닛 자체 Transform.

    public List<GameObject> collBear_1 = new List<GameObject>();

    public float Rabbit_attack_speed;
    float coolTime1;
    //Bear HP;
    // Start is called before the first frame update
    void Start()
    {
        Rabbit_attack_speed = GameManager.instance.Rabbit_attack_speed;
        rabbitTr = GetComponent<Transform>();
        coolTime1 = Rabbit_attack_speed;
        //HP = GameObject.Find("bear").GetComponent<Bear>();
    }
    // Update is called once per frame
    void Update()
    {
        //GameObject[] Bear_1_Tag = GameObject.FindGameObjectsWithTag("Bear_1");
        coolTime1 -= Time.deltaTime; //공격 시간 깍음
        if (coolTime1 < 0)
        {
            for(int i = 0 ;i < collBear_1.Count;i++)
            {
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_1")
                {
                    Bear target = collBear_1[i].GetComponent<Bear>();
                    target.Bear1_HP -= 10;
                    LR_Trun(collBear_1[i]); //좌우 회전(아래 메소드 만들어둠)
                    animator.Play("R1Attack");  //애니메이션 실행. R1Attack 모션이 끝나면 자동으로 R1Stand로 돌아가는 것은 애니메이터에서 구현해둠.
                    
                }
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_2")
                {
                    Bear_2 target = collBear_1[i].GetComponent<Bear_2>();
                    target.Bear2_HP -= 10;
                    LR_Trun(collBear_1[i]);
                    animator.Play("R1Attack");
                    
                }
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_3")
                {
                    Bear_3 target = collBear_1[i].GetComponent<Bear_3>();
                    target.Bear3_HP -= 10;
                    LR_Trun(collBear_1[i]);
                    animator.Play("R1Attack");
                   
                }
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_4")
                {
                    Bear_4 target = collBear_1[i].GetComponent<Bear_4>();
                    target.Bear4_HP -= 10;                   
                    LR_Trun(collBear_1[i]);
                    animator.Play("R1Attack");
                    
                }

            }
            coolTime1 = GameManager.instance.Rabbit_attack_speed;// 토끼 공격속도
            Debug.Log("공격 초기화");
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Bear_1" || coll.tag == "Bear_2")
        {
            collBear_1.Add(coll.gameObject);
        }
        if (coll.tag == "Bear_3" || coll.tag == "Bear_4")
        {
            collBear_1.Add(coll.gameObject);
        }

    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        for(int i = 0; i < collBear_1.Count; i++)
        {
            if(collBear_1[i] == coll.gameObject)
            {
                collBear_1.Remove(collBear_1[i]);
                break;
            }
        }
    }

    private void LR_Trun (GameObject bear)
    {
        if (bear.transform.position.x >= rabbitTr.position.x)
        {
            spriteTr.localScale = new Vector2(1, 1);
        }
        else if (bear.transform.position.x < rabbitTr.position.x)
        {
            spriteTr.localScale = new Vector2(-1, 1);
        }
    }
}
