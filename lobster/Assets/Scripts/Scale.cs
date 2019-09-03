using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    public Animation animator;
    public List<GameObject> collBears = new List<GameObject>();
    public Image image;

    private void OnTriggerEnter2D(Collider2D coll)//추가
    {
        if (coll.tag == "Bear_1" || coll.tag == "Bear_2" || coll.tag == "Bear_3")
        {
            collBears.Add(coll.gameObject);
            Debug.Log("추가됨");
        }
        if (coll.tag == "Bear_4" )
        {
            collBears.Add(coll.gameObject);
            Debug.Log("추가됨");
        }

    }
    private void OnTriggerExit2D(Collider2D coll)//제거
    {
        for (int i = 0; i < collBears.Count; i++)
        {
            if (collBears[i] == coll.gameObject)
            {
                collBears.Remove(collBears[i]);
                Debug.Log("삭제됨");
                break;
            }
        }
    }
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        GameManager.instance.Skill_term -= Time.deltaTime;
        if (Input.GetMouseButtonUp(0) && GameManager.instance.Skill_term < 0)
        {
            for (int i = 0; i < collBears.Count; i++)
            {
                if (collBears[i] != null && collBears[i].tag == "Bear_1")
                {
                    Bear target = collBears[i].GetComponent<Bear>();
                    target.Bear1_HP -= 160;
                    //animator.Play("Bomb");
                }
                if (collBears[i] != null && collBears[i].tag == "Bear_2")
                {
                    Bear_2 target_2 = collBears[i].GetComponent<Bear_2>();
                    target_2.Bear2_HP -= 160;
                    //animator.Play("Bomb");
                }
                if (collBears[i] != null && collBears[i].tag == "Bear_3")
                {
                    Bear_3 target = collBears[i].GetComponent<Bear_3>();
                    target.Bear3_HP -= 160;
                    //animator.Play("Bomb");
                }
                if (collBears[i] != null && collBears[i].tag == "Bear_4")
                {
                    Bear_4 target = collBears[i].GetComponent<Bear_4>();
                    target.Bear4_HP -= 160;
                    //animator.Play("Bomb");
                }
            }
            GameManager.instance.Skill_term = 45f; //스킬 쿨타임 초기화
            Color temp = image.color;
            temp.a = 0.6f;            
            image.color = temp;
        }
        if(GameManager.instance.Skill_term <= 0)
        {
            Color temp2 = image.color;
            temp2.a = 1.0f;
            image.color = temp2;
        }
    }
}
