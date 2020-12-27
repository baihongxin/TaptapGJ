using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    public int i;

    void Start()
    {
        Debug.Log("test");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnValueChanged(float value)
    {
       
        float curPos = UnityEngine.Screen.width * value;
        Debug.Log(curPos);
        GameObject[] objects = GameObject.FindGameObjectsWithTag("ContolObject");
        foreach (GameObject target in objects) {
            ExecuteEvents.Execute<ICustomEventHandler>(target, null, (x, y) => x.SliderChnage(curPos));
        }
       
    }
}
