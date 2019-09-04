using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToExp : MonoBehaviour
{

    void Start()
    {
        gameObject.SetActive(false);
    }
    public void OnClick_StopButton()
    {
        
        gameObject.SetActive(true);

    }

}
