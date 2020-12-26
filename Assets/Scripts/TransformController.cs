using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformController : MonoBehaviour
{
    // Start is called before the first frame update
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
    }
}
