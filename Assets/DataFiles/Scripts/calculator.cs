using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculator : MonoBehaviour
{
    public int counter;
    public TextMesh totalmonsters;
    void Start()
    {
        counter = 0;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increment()
    {
        counter++;
        totalmonsters.text = counter.ToString();
    }
}
