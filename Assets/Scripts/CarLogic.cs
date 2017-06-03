using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLogic : MonoBehaviour {

    Transform myTransform;
    Rigidbody myRigidbody;
    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        myRigidbody.AddForce(myTransform.forward*10);
        
    }
}
