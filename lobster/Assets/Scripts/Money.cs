using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    public Text ScoreText;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "돈:" + GameManager.instance.Money;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ScoreText.text = "돈:" + GameManager.instance.Money;
    }
}
