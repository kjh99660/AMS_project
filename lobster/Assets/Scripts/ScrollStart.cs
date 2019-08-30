using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScrollStart : MonoBehaviour
{

    public float scrollSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //current position
        Vector3 pos = transform.position;


        Vector3 localVectorUp = transform.TransformDirection(0, 1, 0);

        //move
        pos += localVectorUp * scrollSpeed * Time.deltaTime;
        transform.position = pos;
        
    }
}
