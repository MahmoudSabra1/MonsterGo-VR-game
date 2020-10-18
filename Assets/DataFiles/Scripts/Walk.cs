using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour
{
    public GameObject pokeBall;
    public float shootingSpeed = 10;
    public int walkingSpeed = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Camera.main.transform.forward * Time.deltaTime * walkingSpeed;
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject pokego =  Instantiate(pokeBall);
            pokego.transform.position = transform.position;
            Rigidbody rb = pokego.GetComponent<Rigidbody>();
            Camera cam = GetComponentInChildren<Camera>();
            rb.velocity = cam.transform.rotation * Vector3.forward * shootingSpeed;
        }
    }
}
