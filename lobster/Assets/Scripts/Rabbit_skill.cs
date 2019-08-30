using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Rabbit_skill : MonoBehaviour, IDragHandler ,IBeginDragHandler , IEndDragHandler
{
    public static Vector3 defaultposition; //드롭하면 원래 자리로 돌려보내주는 변수 
    public GameObject scale = null;
    
    // Start is called before the first frame update
    void Start()
    {
        defaultposition = this.gameObject.transform.position; //다시 돌아올 자리 설정
    }
    public void OnDrag(PointerEventData eventData)
    {
        Vector3 mouseposition = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        transform.position = mouseposition;
        scale.transform.position = new Vector3 (mouseposition.x , mouseposition.y , 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)// 드래그 시작
    {
        
        
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.position = defaultposition;
        scale.transform.position = new Vector3 (-10,-40, 10);
    }
}
