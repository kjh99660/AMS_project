using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject CreateBear = null;
    public float Spown_term = 3.0f;//스폰되는 간격
    public int Bear_number = 3;//몹 수

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Spown_term -= Time.deltaTime;  // 리스폰 시간을 깍음. 
        if (Spown_term < 0 && Bear_number>0)                  // 리스폰 시간이 0이 되었는지 검사 
        {
            Instantiate(CreateBear, new Vector3(-10, 0.1f, 1), Quaternion.identity); // 생성
            
            Spown_term = 3.0f;// 리스폰시간 초기화
            Bear_number--;

        }
    }
}
