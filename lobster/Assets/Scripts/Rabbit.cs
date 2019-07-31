using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
    GameObject[] Bear_1_Tag = null;
    public List<GameObject> collBear_1 = new List<GameObject>();
    //Bear HP;
    // Start is called before the first frame update
    void Start()
    {
        //HP = GameObject.Find("bear").GetComponent<Bear>();
    }
    // Update is called once per frame
    void Update()
    {
        //GameObject[] Bear_1_Tag = GameObject.FindGameObjectsWithTag("Bear_1");
        GameManager.instance.Bear_attack_speed -= Time.deltaTime; //공격 시간 깍음
        if (GameManager.instance.Bear_attack_speed < 0)
        {
            for(int i=0;i<collBear_1.Count;i++)
            {
                if (collBear_1[i] != null && collBear_1[i].tag == "Bear_1")
                {
                    Bear target = collBear_1[i].GetComponent<Bear>();
                    target.Bear1_HP -= 10;
                }
                if(collBear_1[i] != null && collBear_1[i].tag == "Bear_2")
                {
                    Bear_2 target_2 = collBear_1[i].GetComponent<Bear_2>();
                    target_2.Bear2_HP -= 10;
                }
            }
            GameManager.instance.Bear_attack_speed = 0.5f;

        }
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if(coll.tag == "Bear_1" || coll.tag == "Bear_2")
        {
            collBear_1.Add(coll.gameObject);
            Debug.Log("추가됨");
        }
    
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        for(int i = 0; i < collBear_1.Count; i++)
        {
            if(collBear_1[i] == coll.gameObject)
            {
                collBear_1.Remove(collBear_1[i]);
                Debug.Log("삭제됨");
                break;
            }
        }
    }
}
