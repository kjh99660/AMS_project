using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit_Spawner : MonoBehaviour
{
    public GameObject rabbit = null;
    public GameObject rabbit_2 = null;
    public GameObject rabbit_3 = null;
    public Vector2 MousePosition;
    public Vector2 select;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MousePosition = Input.mousePosition;
        

        if (Input.GetMouseButtonDown(0))
        {
            if(MousePosition.x <688 && MousePosition.x> 565)
            {
                if (MousePosition.y < 266 && MousePosition.y > 190)
                {
                    
                    Instantiate(rabbit, select, Quaternion.identity);
                }
                if (MousePosition.y < 188 && MousePosition.y > 113)
                {

                    Instantiate(rabbit_2, select, Quaternion.identity);
                }
                if (MousePosition.y < 109 && MousePosition.y > 29)
                {

                    Instantiate(rabbit_3, select, Quaternion.identity);
                }
            }
        }
    }
}
