using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;


public class GrassGroundController : MonoBehaviour, ICustomEventHandler
{
    public float offset = 200;
    public float position;
    public GameObject winter;
    public GameObject summer;
    private Vector3 curposition;

    public void SliderChnage(float position)
    {
        this.position = position;
        Debug.Log("sliderChange:" + position);
    }

    void Start()
    {
        curposition = Camera.main.WorldToScreenPoint(this.transform.position);
        if (curposition.x - offset > position)
        {
            winter.SetActive(false);
            summer.SetActive(true);
        }
        else
        {
            winter.SetActive(true);
            summer.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (curposition.x - offset > position)
        {
            winter.SetActive(false);
            summer.SetActive(true);
        }
        else
        {
            winter.SetActive(true);
            summer.SetActive(false);
        }

    }
}
