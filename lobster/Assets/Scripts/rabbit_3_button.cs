using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rabbit_3_button : MonoBehaviour
{
    public GameObject rabbit_3 = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Makerabbit()
    {
        Instantiate(rabbit_3, new Vector3(GameManager.instance.MousePosition.x, GameManager.instance.MousePosition.y, 1), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
