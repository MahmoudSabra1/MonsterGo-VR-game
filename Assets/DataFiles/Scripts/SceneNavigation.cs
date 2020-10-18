using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneNavigation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayscene()
    {
        SceneManager.LoadScene("DayScene");
    }

    public void nightscene()
    {
        SceneManager.LoadScene("NightScene");
    }

    public void exit()
    {
        Application.Quit();
    }
}
