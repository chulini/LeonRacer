using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeonRacer : MonoBehaviour {
    [SerializeField] CarLogic mainPlayer;
    [SerializeField] Transform lockToTrack;
    int trackCounter = 0;
    void Reset()
    {
        trackCounter = 0;
    }
    void Start () {
        Reset();
	}
    
    void Update()
    {
        if(mainPlayer.myTransform.position.z > trackCounter * 96f){
            trackCounter++;
            GameObject newTrack = SmartPool.Spawn("Track"+Random.Range(0,3).ToString());
            newTrack.transform.position = new Vector3(0, 0, 96f * trackCounter);
        }
    }
    private void FixedUpdate()
    {
        lockToTrack.position = new Vector3(0, mainPlayer.myTransform.position.y, mainPlayer.myTransform.position.z);
    }

}
