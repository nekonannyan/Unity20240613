using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{

    public float speed = 10;
    Rigidbody myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        myRigidbody.velocity = new Vector3(Input.GetAxis("Horizontal")*speed,0f,0f);
    }
}
