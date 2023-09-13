using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsileSpawner : MonoBehaviour
{
    public GameObject capsileObject;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            int x = Random.Range(-10, 10);
            int z = Random.Range(-10, 10);
            //Debug.Log(Time.time);
            Instantiate(capsileObject, new Vector3(x, 5, z), Quaternion.identity);
        }
    }
}
