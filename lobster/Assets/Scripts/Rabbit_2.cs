using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_2 : MonoBehaviour
{
    public Animator animator;
    public Transform spriteTr;  //유닛이 통채로 좌우반전 되는 게 아니라 스프라이트만 반전돼야 하므로 스프라이트 오브젝트의 Transform을 따로 건드림.
    private Transform rabbitTr;  //유닛 자체 Transform.

    public List<GameObject> collBear_1 = new List<GameObject>();
    // Start is called before the first frame update
    public float Rabbit2_attack_speed;
    float coolTime;
    void Start()
    {
        Rabbit2_attack_speed = GameManager.instance.Rabbit2_attack_speed;
        rabbitTr = GetComponent<Transform>();
        coolTime = Rabbit2_attack_speed;
    }
    // Update is called once per frame
    void Update()
    {
        //GameObject[] Bear_1_Tag = GameObject.FindGameObjectsWithTag("Bear_1");
        coolTime -= Time.deltaTime; //공격 시간 깍음
        if (coolTime < 0)
        {
            for (int i = 0; i < collBear_1.Count; i++)
            {
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_1")
                {
                    Bear target = collBear_1[i].GetComponent<Bear>();
                    LR_Trun(collBear_1[i]); //좌우 회전(아래 메소드 만들어둠)
                    animator.Play("R2Attack");  //애니메이션 실행. R1Attack 모션이 끝나면 자동으로 R1Stand로 돌아가는 것은 애니메이터에서 구현해둠.
                    target.Bear1_HP -= 20; //토끼 공격력
                    i = collBear_1.Count;
                    continue;
                }
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_2")
                {
                    Bear_2 target_2 = collBear_1[i].GetComponent<Bear_2>();
                    LR_Trun(collBear_1[i]);
                    animator.Play("R2Attack");
                    target_2.Bear2_HP -= 20; //토끼 공격력
                    i = collBear_1.Count;
                    continue;
                }
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_3")
                {
                    Bear_3 target_3 = collBear_1[i].GetComponent<Bear_3>();
                    LR_Trun(collBear_1[i]);
                    animator.Play("R2Attack");
                    target_3.Bear3_HP -= 20; //토끼 공격력
                    i = collBear_1.Count;
                    continue;
                }
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_4")
                {
                    Bear_4 target_4 = collBear_1[i].GetComponent<Bear_4>();
                    LR_Trun(collBear_1[i]);
                    animator.Play("R2Attack");
                    target_4.Bear4_HP -= 20; //토끼 공격력
                    i = collBear_1.Count;
                    continue;
                }
            }
            coolTime = GameManager.instance.Rabbit2_attack_speed;
        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.tag == "Bear_1" || coll.tag == "Bear_2" || coll.tag == "Bear_3" || coll.tag == "Bear_4")
        {
            collBear_1.Add(coll.gameObject);
        }

    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        for (int i = 0; i < collBear_1.Count; i++)
        {
            if (collBear_1[i] == coll.gameObject)
            {
                collBear_1.Remove(collBear_1[i]);
                break;
            }
        }

    }
    private void LR_Trun(GameObject bear)
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
