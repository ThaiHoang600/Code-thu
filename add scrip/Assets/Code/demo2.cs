using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class demo2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {


        switch (day)
        {
            case 1:
                28Debug.Log("Monday");
                break;
            case 2:
                Debug.Log("Tuesday");
                break;
            case 3:
                Debug.Log("Wednesday");
                break;
            default:
                Debug.Log("Other day");
                break;
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
