using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
   
    public List<GameObject> collBears = new List<GameObject>();
    public Image image;
    public GameObject CreateMusa = null;
 
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
        
        Vector3 mouposition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        GameManager.instance.Skill_term -= Time.deltaTime;
        if (Input.GetMouseButtonUp(0) && GameManager.instance.Skill_term < 0 && GameManager.instance.skill == true)
        {
            Instantiate(CreateMusa, new Vector3(mouposition.x, mouposition.y, -4), Quaternion.identity);          
            GameManager.instance.Skill_term = 45f; //스킬 쿨타임 초기화
            Color temp = image.color;
            temp.a = 0.6f;            
            image.color = temp;
        }
        if(GameManager.instance.Skill_term <= 0)
        {
            Color temp2 = image.color;
            temp2.a = 1.0f;
            image.color = temp2;
        }
    }
}
