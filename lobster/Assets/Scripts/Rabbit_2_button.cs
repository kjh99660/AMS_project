﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_2_button : MonoBehaviour
{
    public GameObject rabbit_pos1 = null;
    public GameObject rabbit_help2 = null;
    public GameObject rabbit_help1 = null;
    public GameObject rabbit_help3 = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Makerabbit_2()
    {
        GameManager.instance.rabbit_number = 2; //토끼번호 2
        rabbit_pos1.SetActive(true);
        rabbit_help2.SetActive(true);
        rabbit_help1.SetActive(false);
        rabbit_help3.SetActive(false);
        //Instantiate(rabbit_2, new Vector3(GameManager.instance.MousePosition.x, GameManager.instance.MousePosition.y, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
