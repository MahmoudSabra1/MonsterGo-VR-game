using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    calculator calc;
    int monstercount = 0;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        calc = FindObjectOfType<calculator>();
        monstercount = calc.counter;
        score.text = monstercount.ToString();
        Destroy(calc.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
