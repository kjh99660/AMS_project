using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_explain : MonoBehaviour
{
    public GameObject panel = null;
    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnClick_MenuOpenButton()
    {
        if (panel.gameObject.activeSelf == true)
        {
            panel.gameObject.SetActive(false);
            Debug.Log("꺼짐");
        }
        else
        {
            panel.gameObject.SetActive(true);
            Debug.Log("켜짐");
        }
       //gameObject.SetActive(!gameObject.active);

    }
}
