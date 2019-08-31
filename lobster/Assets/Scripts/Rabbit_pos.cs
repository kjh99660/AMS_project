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


    public Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
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
                Debug.Log("1 소환");
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
                Debug.Log("2 소환");
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
                Debug.Log("3 소환");
                Destroy(gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
