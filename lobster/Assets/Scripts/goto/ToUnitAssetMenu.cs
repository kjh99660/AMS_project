using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToUnitAssetMenu : MonoBehaviour
{
    // Start is called before the first frame update
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
        if(panel.gameObject.activeSelf == true)
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
