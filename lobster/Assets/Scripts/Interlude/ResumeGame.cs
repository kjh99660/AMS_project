using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeGame : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCLick_Sound()
    {
        SoundManager.PlaySound("click");
    }

    public void OnClick_ResumeButton()
    {
        Time.timeScale = 1;

        gameObject.SetActive(false);

    }
}
