using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPlatformController : MonoBehaviour
{
    public float HtravelDistance;
    public float speed;
    

    bool flag;
    Vector3 StartPosition;


    
    void Start()
    {
        // flag = true;
        // StartPosition = transform.position;
    }

    
    void Update()
    {
        // if (flag)
        // {
        //     transform.position = transform.position + new Vector3(speed, 0.0f, 0.0f);
        // }
        // else
        // {
        //     transform.position = transform.position - new Vector3(speed, 0.0f, 0.0f);
        // }


        // if (transform.position.x >= StartPosition.x + HtravelDistance)
        // {
        //     flag = !flag;
        // }
        // else if (transform.position.x <= StartPosition.x)
        // {
        //     flag = !flag;
        // }

    }

}
