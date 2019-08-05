using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }


    public void OnClick_StopButton()
    {

        Time.timeScale = 0;
        gameObject.SetActive(true);

    }

}
