using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelChecker : MonoBehaviour
{
    public RawImage rawImage;
    public float timer = 3.0f;
    public bool nextFlag = false;
    public float timerF = 1.0f;
    public float timerF2 = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        rawImage.canvasRenderer.SetAlpha(0);
    }

    // Update is called once per frame
    void Update()
    {
        if (nextFlag) {
            timer -= Time.deltaTime;
            timerF -= Time.deltaTime;
            if (timerF <= 0) {
                timerF2--;
                rawImage.canvasRenderer.SetAlpha(1);
                timerF = 1.0f;
            }
    
            if (timer <= 0)
            {
                Debug.Log(string.Format("Timer1 is up !!! time=${0}", Time.time));
                Scene scene = SceneManager.GetActiveScene();
                if (scene.name == "Level2")
                {
                    rawImage.canvasRenderer.SetAlpha(0);
                }
                else if (scene.name == "Level1") {
                    SceneManager.LoadScene(1);
                    rawImage.canvasRenderer.SetAlpha(0);
                }
         
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
            nextFlag = true;


        }
    }
}
