using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForest : MonoBehaviour
{
    public GameObject[] trees;
    public GameObject[] rockgrass;
    void Start()
    {
        for (int i = 0; i < Random.Range(700, 800); i++)
        {
            treecount();
        }

        for (int i = 0; i < Random.Range(200, 300); i++)
        {
            rockgrasscount();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    void treecount()
    {
        int treeindex = Random.Range(0, trees.Length);
        GameObject rforest = Instantiate(trees[treeindex]);
        rforest.transform.parent = transform;
        rforest.transform.localPosition = new Vector3(Random.Range(-90, 90), 0.0f, Random.Range(-90, 90));
    }

    void rockgrasscount()
    {
        int rockgrassindex = Random.Range(0, rockgrass.Length);
        GameObject rrocckgrass = Instantiate(rockgrass[rockgrassindex]);
        rrocckgrass.transform.parent = transform;
        rrocckgrass.transform.localPosition = new Vector3(Random.Range(-90, 90), 0.0f, Random.Range(-90, 90));
    }

}
