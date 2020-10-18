using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMonsters : MonoBehaviour
{
    public GameObject[] diffmonsters;
    void Start()
    {
        for(int i = 0; i < Random.Range(250, 300); i++)
        {
            monstercount();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void monstercount()
    {
        int monsterindex = Random.Range(0, diffmonsters.Length);
        GameObject rmonster = Instantiate(diffmonsters[monsterindex]);
        rmonster.transform.parent = transform;
        rmonster.transform.localPosition = new Vector3 (Random.Range(-60, 60), 0.0f, Random.Range(-60, 60));
    }
}
