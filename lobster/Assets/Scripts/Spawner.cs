using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CreateBear = null;
    public GameObject CreateBear_2 = null;
    public GameObject CreateBear_3 = null;
    

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Bear.Spown_term -= Time.deltaTime;  // 리스폰 시간을 깍음. 
        if (Bear.Spown_term < 0 && Bear.Bear_number > 0)                  // 리스폰 시간이 0이 되었는지 검사 
        {
            if (Bear.stage_level == 1)
            {
                Instantiate(CreateBear, new Vector3(-10, 0.1f, 1), Quaternion.identity); // 생성

                Bear.Spown_term = 3.0f;// 리스폰시간 초기화
                Bear.Bear_number--;
            }
            if(Bear.stage_level == 2)
            {
                Instantiate(CreateBear, new Vector3(-9, -13, 1), Quaternion.identity); // 생성

                Bear.Spown_term = 3.0f;// 리스폰시간 초기화
                Bear.Bear_number--;
            }

        }
        
    }
}
