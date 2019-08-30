using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasKeep : MonoBehaviour
{
    public static CanvasKeep instance = null;

    //초기화
    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
}
