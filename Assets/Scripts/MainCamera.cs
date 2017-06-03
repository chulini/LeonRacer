using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    [SerializeField] Transform target;
    Transform myTransform;
    Vector3 cameraOffset;
    private void Awake()
    {
        myTransform = GetComponent<Transform>();
        cameraOffset = myTransform.position - target.position;
    }
    void FixedUpdate () {
        Quaternion targetRotation = Quaternion.LookRotation(target.position + Vector3.forward*10f - myTransform.position);
        myTransform.rotation = Quaternion.Lerp(myTransform.rotation, targetRotation, Time.deltaTime);
        myTransform.position = Vector3.Lerp(myTransform.position, target.position + cameraOffset, Time.deltaTime*5f);
    }
}
