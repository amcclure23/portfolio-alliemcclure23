using System.Collections;
using System.Collections.Generic;
using Oculus.Interaction;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public GameObject cube;
    public GameObject textObj;
    public void destroyCube() 
    {
        Vector3 i = cube.gameObject.transform.position;
        i.x = 10;
        cube.transform.position = i;
    } 
        
    public void noButton()
    {
        StartCoroutine(thing());
    }

    IEnumerator thing()
    {
        textObj.SetActive(true);
        yield return new WaitForSecondsRealtime(.5f);
        textObj.SetActive(false);
    }
}
