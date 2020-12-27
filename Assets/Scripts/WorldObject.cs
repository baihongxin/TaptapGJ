using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorldObject : MonoBehaviour
{
    

    public int state = -1;


    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (this.state == 1)
        {
            Debug.Log("我是冰");
        }
        else {
            Debug.Log("我是水");
        }

        Debug.Log("state2:" + this.state);
    }

    public void OnValueChanged(float value)
    {

        var controlX = UnityEngine.Screen.width * value;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Debug.Log(screenPoint + "   " + screenPoint.x  + " " + controlX);
        if (screenPoint.x < controlX)
        {
            
            this.state = 1;
        } else
        {
            this.state = 2;
        }
        Debug.Log("state:" + state);
    }
}
