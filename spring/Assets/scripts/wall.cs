using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "wall")
        {
            UnityEngine.Vector3 myVector = new UnityEngine.Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-5, 5), UnityEngine.Random.Range(-10, 10));
            body.AddRelativeForce(myVector);
        }
    }
}
