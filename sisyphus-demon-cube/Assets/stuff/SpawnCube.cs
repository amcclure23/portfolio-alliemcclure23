using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCube : MonoBehaviour
{
    public OVRCameraRig player;
    public Rigidbody rb;
    Vector3 startPosition;
    int distance = 3;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.y> player.transform.position.y + distance) 
        {
            StartCoroutine(waiting());
        }
        else if (this.transform.position.x > player.transform.position.x + distance)
        {
            StartCoroutine(waiting());
        }
        else if (this.transform.position.z > player.transform.position.z + distance)
        {
            StartCoroutine(waiting());
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "floor")
        {
            StartCoroutine(waiting());
        }
    }

    IEnumerator waiting()
    {
        yield return new WaitForSecondsRealtime(2);
        rb.velocity = new Vector3(0, 0, 0);
        this.transform.position = startPosition;
    }
    
}
