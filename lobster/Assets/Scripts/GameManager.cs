using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int stage_level = 1; //단계
    public float Spown_term = 3.0f;//스폰되는 간격 -> 여기서 수정 불가
    public int Bear_number = 3;//몹 수
    public float Bear_speed = 3.0f;//몹 속도
    public float Bear_attack_speed = 1.0f; //곰 공속 -> 여기서 수정 불가
    public Vector2 MousePosition;//클릭한 마우스 위치
    public int Money=100; //시작 돈

    private void Awake()
    {
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            MousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));

        }
    }
}
