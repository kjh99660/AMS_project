using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int stage_level = 3; //단계
    public Vector2 MousePosition;//클릭한 마우스 위치
    public bool skill = false; //스킬 시행 유무
    public int Money = 100; //시작 돈
    public int life = 10; //목숨
    public int rabbit_number = 1;//UI 에서 선택한 토끼 종류 결정
    public float Skill_term = 0f; //스킬 쿨타임
    public float Stun_term = 1.0f;// 스턴 지속시간
    public float Speed_up = 2; //증가하는 속도값

    public float Spown_term = 3.0f;//1번 곰이 스폰되는 간격 -> 여기서 수정 불가
    public int Bear_number = 40;//1번 곰의 수
    public float Bear_speed = 3.8f;//1번 곰의 속도
  
    public float Spown_term_2 = 5.5f;//2번 곰이 스폰되는 간격 -> 여기서 수정 불가
    public int Bear_2_number = 30; //2번 곰의 수
    public float Bear_2_speed = 6.0f;//2번 곰의 속도

    public float Spown_term_3 = 3.0f;//3번 곰이 스폰되는 간격 -> 여기서 수정 불가
    public int Bear_3_number = 3;//3번 곰의 수
    public float Bear_3_speed = 3.0f; //3번 곰의 속도

    public float Spown_term_4 = 4.0f;//4번 곰이 스폰되는 간격 -> 여기서 수정 불가
    public int Bear_4_number = 3;//4번 곰의 수
    public float Bear_4_speed = 3.0f; //4번 곰의 속도

    public float Bear_b_speed = 4.0f;// 보스곰 속도
    public int Bear_b_number = 1; //보스곰 수
    public float Spown_term_b = 205f; //보스곰 스폰 간격

    public float Rabbit_attack_speed = 1.35f; //토끼 공속
    public float Rabbit2_attack_speed = 2f; //토끼2 공속
    public float Rabbit3_attack_speed = 1.6f; //토끼3 공속


    private void Awake()
    {
        instance = this;
    }
  
    
}
