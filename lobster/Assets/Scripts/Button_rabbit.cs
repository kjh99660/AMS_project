﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_rabbit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rabbit = null;
    
    void Start()
    {
        
    }
    public void Makerabbit()
    {
        Instantiate(rabbit, new Vector3(GameManager.instance.MousePosition.x, GameManager.instance.MousePosition.y, 1), Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
