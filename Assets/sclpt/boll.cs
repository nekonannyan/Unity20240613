using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    public float speed = 5;
    Rigidbody miRigidbody;

    private void Start()
    {
        miRigidbody = GetComponent<Rigidbody>();
        miRigidbody.velocity = new Vector3(speed,speed,0);  
    }

}
