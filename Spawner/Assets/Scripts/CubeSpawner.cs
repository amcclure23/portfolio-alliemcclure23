using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cubeObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            int x = Random.Range(-10, 10);
            int z = Random.Range(-10, 10);
            //Debug.Log(Time.time);
            Instantiate(cubeObject, new Vector3(x, 5, z), Quaternion.identity);
        }
    }
}
