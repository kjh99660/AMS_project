using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    public Text LifeText;
    // Start is called before the first frame update
    void Start()
    {
        LifeText.text = "떡:" + GameManager.instance.life;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        LifeText.text = "떡:" + GameManager.instance.life;
    }
}
