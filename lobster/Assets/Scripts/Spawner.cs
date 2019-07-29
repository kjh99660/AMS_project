using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CreateBear = null;
    public GameObject CreateBear_2 = null;
    public GameObject CreateBear_3 = null;
    public List<GameObject> Fake_Bear = new List<GameObject>();
    public int Bear_numbering = 0;
    public GameObject fake_bear = null;

  
    void Start()
    {

        
    }


    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        GameManager.instance.Spown_term -= Time.deltaTime;  // 리스폰 시간을 깍음. 
        if (GameManager.instance.Spown_term < 0 && GameManager.instance.Bear_number > 0)// 리스폰 시간이 0이 되었는지 검사 
        {
            if (GameManager.instance.stage_level == 1)
            {
                fake_bear = Instantiate(CreateBear, new Vector3(-10, 0.1f, 1), Quaternion.identity); // 생성
                Fake_Bear.Add(fake_bear);
                GameManager.instance.Spown_term = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
                Bear_numbering++;
                Debug.Log("한마리 복제함");
            }

            if(GameManager.instance.stage_level == 2)
            {
              //  Fake_Bear = Instantiate(CreateBear, new Vector3(-8.5f, 1.88f, 1), Quaternion.identity); // 생성

                GameManager.instance.Spown_term = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
            }

        }
        for (int i = 0; i < Bear_numbering; i++)
        {
            if (Fake_Bear[i] == null) break;
            if ((Fake_Bear[i]).GetComponent<Bear>().Bear1_HP < 0)
            {
                Destroy(Fake_Bear[i].gameObject);
            }
         }

    }
}
