using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChecker : MonoBehaviour
{
    public Text text;
    public float timer = 3.0f;
    public bool nextFlag = false;
    public float timerF = 1.0f;
    public float timerF2 = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (nextFlag) {
            timer -= Time.deltaTime;
            timerF -= Time.deltaTime;
            if (timerF <= 0) {
                timerF2--;
                text.text = "恭喜你过了第一关 \n " + timerF2;
                timerF = 1.0f;
            }
    
            if (timer <= 0)
            {
                Debug.Log(string.Format("Timer1 is up !!! time=${0}", Time.time));
                SceneManager.LoadScene(1);
                timer = 3.0f;
                nextFlag = false;
            }
        }

    }

    void OnTriggerEnter(Collider other)
    {
        string collidName = other.name;
        Debug.Log("collid:" + collidName);
        if (collidName == "Player") {
            text.text = "恭喜你过了第一关 \n 3";
            nextFlag = true;


        }
    }
}
