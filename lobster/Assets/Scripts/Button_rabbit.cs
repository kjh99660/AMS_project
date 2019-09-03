using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_rabbit : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject rabbit_help1 = null;
    public GameObject rabbit_pos1 = null;
     
    
    
    void Start()
    {
        
    }
    public void Makerabbit()
    {
        GameManager.instance.rabbit_number = 1; //토끼번호 1
        rabbit_pos1.SetActive(true);
        rabbit_help1.SetActive(true);
        //Instantiate(rabbit, new Vector3((int)GameManager.instance.MousePosition.x -0.2f , (int)GameManager.instance.MousePosition.y, 1), Quaternion.identity);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
