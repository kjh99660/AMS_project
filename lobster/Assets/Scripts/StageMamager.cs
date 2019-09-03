using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageMamager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject level_1 = null;
    public GameObject level_2 = null;
    public GameObject level_3 = null;
    public GameObject level_4 = null;
    public int stage = 0;
    void Start()
    {
        if(stage == 0)
        {
            level_1.SetActive(true);
            level_2.SetActive(false);
            level_3.SetActive(false);
            level_4.SetActive(false);
        }
        if (stage == 1)
        {
            level_1.SetActive(true);
            level_2.SetActive(true);
            level_3.SetActive(false);
            level_4.SetActive(false);
        }
        if (stage == 2)
        {
            level_1.SetActive(true);
            level_2.SetActive(true);
            level_3.SetActive(true);
            level_4.SetActive(false);
        }
        if (stage == 3)
        {
            level_1.SetActive(true);
            level_2.SetActive(true);
            level_3.SetActive(true);
            level_4.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
