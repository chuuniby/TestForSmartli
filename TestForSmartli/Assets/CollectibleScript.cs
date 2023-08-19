using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleScript : MonoBehaviour
{
    public Vector3 originalPos;
    public Vector3 upPos;
    public bool moveUp;
    void Start()
    {
        originalPos = transform.position;
        upPos = new Vector3(transform.position.x,transform.position.y + 2f,transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position,originalPos) < 0.02f)
            moveUp = true;
        if(moveUp)
        transform.position = Vector3.Lerp(transform.position, upPos, Time.deltaTime);
        if(Vector3.Distance(transform.position,upPos) < 0.02f)
            moveUp = false;
        if(!moveUp)
        transform.position = Vector3.Lerp(transform.position, originalPos, Time.deltaTime);
    }
}
