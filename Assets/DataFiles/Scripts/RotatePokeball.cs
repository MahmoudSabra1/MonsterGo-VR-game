using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePokeball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(300, 300, 300) * Time.deltaTime);
    }
}
