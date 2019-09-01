using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbit_3_button : MonoBehaviour
{
    public GameObject rabbit_3 = null;
    public GameObject rabbit_pos1 = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Makerabbit_3()
    {
        GameManager.instance.rabbit_number = 3; //토끼번호 3
        rabbit_pos1.SetActive(true);
        //Instantiate(rabbit_3, new Vector3(GameManager.instance.MousePosition.x, GameManager.instance.MousePosition.y, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
