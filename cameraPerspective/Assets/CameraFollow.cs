using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 thirdPOffset = new Vector3(0,1,-4);
    Vector3 firstPOffset = new Vector3(0,0,0);
    Vector3 offset;
    int chan = 0;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(chan == 0) { chan++; }
            else { chan--; }
        }
        if(chan == 0) { offset = thirdPOffset; }
        else { offset = firstPOffset; }
            transform.position = player.position + offset;
    }
}
