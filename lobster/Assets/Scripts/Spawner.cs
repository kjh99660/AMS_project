using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CreateBear = null;
    public GameObject CreateBear_2 = null;
    public GameObject CreateBear_3 = null;

    public List<GameObject> Fake_Bear1 = new List<GameObject>();
    public List<GameObject> Fake_Bear2 = new List<GameObject>();

    public int Bear1_numbering = 0;
    public int Bear2_numbering = 0;

  
    void Start()
    {

        
    }


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        GameManager.instance.Spown_term -= Time.deltaTime;  //곰 1 리스폰 시간을 깍음. 
        GameManager.instance.Spown_term_2 -= Time.deltaTime; //곰 2 리스폰 시간을 깍음.
        if (GameManager.instance.Spown_term < 0 && GameManager.instance.Bear_number > 0)// 리스폰 시간이 0이 되었는지 검사 
        {
            if (GameManager.instance.stage_level == 1)
            {
                GameObject newBear = Instantiate(CreateBear, new Vector3(-10, 0.1f, -4), Quaternion.identity); //곰 1 생성
                Fake_Bear1.Add(newBear);

                GameManager.instance.Spown_term = 3.0f;
                GameManager.instance.Bear_number--;//곰 1 리스폰 시간 및 소환 수 처리

                Bear1_numbering ++;
                Debug.Log("곰_1 복제함");
                
            }

            if(GameManager.instance.stage_level == 2)
            {
                GameObject newBear_2 = Instantiate(CreateBear, new Vector3(-8.5f, -13.05f, -4), Quaternion.identity); // 생성
                Fake_Bear1.Add(newBear_2);

                GameManager.instance.Spown_term = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
                Bear1_numbering++;
                Debug.Log("곰 _1 한마리 복제함");
            }

        }
        if (GameManager.instance.Spown_term_2 < 0 && GameManager.instance.Bear_2_number > 0)// 리스폰 시간이 0이 되었는지 검사
        {
            if (GameManager.instance.stage_level == 1)
            {
                GameObject newBear_2 = Instantiate(CreateBear_2, new Vector3(-10, 0.1f, -4), Quaternion.identity); //곰 2 생성
                Fake_Bear2.Add(newBear_2);

                GameManager.instance.Spown_term_2 = 3.0f;
                GameManager.instance.Bear_2_number--;//곰 2 리스폰 시간 및 소환 수 처리

                Bear2_numbering ++;
                Debug.Log("곰 _2 복제함");

            }

            if (GameManager.instance.stage_level == 2)
            {
                GameObject newBear_2 = Instantiate(CreateBear_2, new Vector3(-8.5f, -13.05f, -4), Quaternion.identity); // 생성
                Fake_Bear2.Add(newBear_2);

                GameManager.instance.Spown_term_2 = 3.0f;
                GameManager.instance.Bear_2_number--;//곰 2 리스폰 시간 및 소환 수 처리

                Bear2_numbering++;
                Debug.Log("곰 _2 복제함");
            }
        }
            for (int i = 0; i < Bear1_numbering; i++)
        {
            if (Fake_Bear1[i] == null) continue;
            if ((Fake_Bear1[i]).GetComponent<Bear>() == null) continue;
            if ((Fake_Bear1[i]).GetComponent<Bear>().Bear1_HP < 0)
            {
                Destroy(Fake_Bear1[i].gameObject);
                GameManager.instance.Money += 20;
                Debug.Log("잡음");
            }
         }
        for (int i = 0; i < Bear2_numbering; i++)
        {
            if (Fake_Bear2[i] == null) continue;
            if ((Fake_Bear2[i]).GetComponent<Bear_2>() == null) continue;
            if ((Fake_Bear2[i]).GetComponent<Bear_2>().Bear2_HP < 0)
            {
                Destroy(Fake_Bear2[i].gameObject);
                GameManager.instance.Money += 20;
                Debug.Log("잡음");
            }
        }

    }
}
