using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_pos : MonoBehaviour
{
    public GameObject rabbit = null;
    public GameObject rabbit_2 = null;
    public GameObject rabbit_3 = null;
    public GameObject rabbit_pos1 = null;
    public GameObject panel = null;
    Button_rabbit button_Rabbit = null;
    Rabbit_2_button button_Rabbit2 = null;
    rabbit_3_button button_Rabbit3 = null;


    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        button_Rabbit = GameObject.Find("rabbit_1_button").GetComponent<Button_rabbit>();
        button_Rabbit2 = GameObject.Find("rabbit_2_button").GetComponent<Rabbit_2_button>();
        if(GameManager.instance.stage_level != 1)
        button_Rabbit3 = GameObject.Find("rabbit_3_button").GetComponent<rabbit_3_button>();
        position = this.gameObject.transform.position;
        position.y -= 0.6f;
    }

    public void MakeRabbits()
    {
        if(GameManager.instance.rabbit_number == 1)
        {
            if (GameManager.instance.Money >= 100)
            {
                GameManager.instance.Money -= 100;
                Instantiate(rabbit, position, Quaternion.identity);
                rabbit_pos1.SetActive(false);
                panel.SetActive(false);
                button_Rabbit.rabbit_help1.SetActive(false);
                Destroy(gameObject);
            }
            
        }
        if(GameManager.instance.rabbit_number == 2)
        {
            if (GameManager.instance.Money >= 160)
            {
                GameManager.instance.Money -= 160;
                Instantiate(rabbit_2, position, Quaternion.identity);
                rabbit_pos1.SetActive(false);
                panel.SetActive(false);
                button_Rabbit2.rabbit_help2.SetActive(false);
                Destroy(gameObject);
            }
        }
        if(GameManager.instance.rabbit_number == 3)
        {
            if (GameManager.instance.Money >= 200)
            {
                GameManager.instance.Money -= 200;
                Instantiate(rabbit_3, position, Quaternion.identity);
                rabbit_pos1.SetActive(false);
                panel.SetActive(false);
                button_Rabbit3.rabbit_help3.SetActive(false);
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
