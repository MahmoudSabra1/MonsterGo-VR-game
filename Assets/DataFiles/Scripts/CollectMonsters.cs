using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CollectMonsters : MonoBehaviour
{
    calculator mcalc;
    // Start is called before the first frame update
    void Start()
    {
        mcalc = FindObjectOfType<calculator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("bluemonster"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            mcalc.increment();
            
        }
        if (other.gameObject.CompareTag("redmonster"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            mcalc.increment();

        }
        if (other.gameObject.CompareTag("yellowmonster"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            mcalc.increment();

        }
        if (other.gameObject.CompareTag("violetmonster"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
            mcalc.increment();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("groundtag"))
        {
            Destroy(gameObject);
        }
    }
}
