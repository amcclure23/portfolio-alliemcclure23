using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class obj : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    int jointCounter = 0;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ball")
        {
            SpringJoint joint = gameObject.AddComponent<SpringJoint>();
            joint.anchor = collision.contacts[jointCounter].point;
            joint.connectedBody = collision.contacts[jointCounter].otherCollider.transform.GetComponentInParent<Rigidbody>();
            jointCounter++;
        }
        
    }
}
