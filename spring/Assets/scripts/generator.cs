using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject[] prefab;
    GameObject[] pink = new GameObject[20];
    GameObject[] purple = new GameObject[20];
    GameObject[] blue = new GameObject[20];
    GameObject[] green = new GameObject[20];

    //counters

    int pk = 0;
    int pr = 0;
    int bl = 0;
    int gr = 0;
    int frameCounter = 0;
    int ballCounter = 0;
    int rotationCount = 0;

    UnityEngine.Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void Update()
    {

        frameCounter++;
        
        //Debug.Log(frameCounter);
        if (frameCounter == 200 && ballCounter != 80)
        {
            ballCounter++;
            myVector = new UnityEngine.Vector3(UnityEngine.Random.Range(-10, 10), UnityEngine.Random.Range(-5, 5), UnityEngine.Random.Range(-10, 10));
            switch (rotationCount)
            {


                case 0: //pink
                    pink[pk] = Instantiate(prefab[0]);
                    pink[pk].GetComponent<Rigidbody>().AddRelativeForce(myVector);
                    pk++;
                    rotationCount++;
                    break;
                case 1://purple
                    purple[pr] = Instantiate(prefab[1]);
                    purple[pr].GetComponent<Rigidbody>().AddRelativeForce(myVector);
                    pr++;
                    rotationCount++;
                    break;
                case 2://blue
                    blue[bl] = Instantiate(prefab[2]);
                    blue[bl].GetComponent<Rigidbody>().AddRelativeForce(myVector);

                    bl++;
                    rotationCount++;
                    break;
                case 3://green
                    green[gr] = Instantiate(prefab[3]);
                    green[gr].GetComponent<Rigidbody>().AddRelativeForce(myVector);
                    gr++;
                    rotationCount = 0;
                    break;
            }
            frameCounter = 0;
        }
        
    }
}

