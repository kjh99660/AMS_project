using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CreateBear = null;
    public GameObject CreateBear_2 = null;
    public GameObject CreateBear_3 = null;
    
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
                Instantiate(CreateBear, new Vector3(-10, 0.1f, 1), Quaternion.identity); // 생성

                GameManager.instance.Spown_term = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
            }

            if(GameManager.instance.stage_level == 2)
            {
                Instantiate(CreateBear, new Vector3(-8.5f, 1.88f, 1), Quaternion.identity); // 생성

                GameManager.instance.Spown_term = 3.0f;// 리스폰시간 초기화
                GameManager.instance.Bear_number--;
            }

        }
        
    }
}
