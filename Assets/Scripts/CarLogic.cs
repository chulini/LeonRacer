using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLogic : MonoBehaviour {
    [HideInInspector]
    public Transform myTransform;
    Rigidbody myRigidbody;
    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        myRigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        //Debug.Log(myRigidbody.velocity.magnitude);
        //50 is max speed
        if(myRigidbody.velocity.magnitude < 50f)
            myRigidbody.AddForce(myTransform.forward* 200f * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddTorque(new Vector3(0, -Time.fixedDeltaTime * 40f, 0));
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddTorque(new Vector3(0, Time.fixedDeltaTime * 40f, 0));
        } else
        {
            myRigidbody.angularVelocity = Vector3.zero;

        }

    }
    public void ChangeColor()
    {
        GetComponentInChildren<CarModel>().ChangeColor();
    }
}
