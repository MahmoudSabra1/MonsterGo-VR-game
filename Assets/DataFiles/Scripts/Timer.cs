using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeremaining;
    public TextMesh timertext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeremaining -= Time.deltaTime;
        timertext.text = Mathf.Floor(timeremaining).ToString();
        if(timeremaining < 1)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
