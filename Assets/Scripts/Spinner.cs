using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xvalue = 0f;//giving values for X
    [SerializeField] float yvalue = 2f;//giving values for Y
    [SerializeField] float zvalue = 0f;//giving values for Z



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xvalue, yvalue, zvalue);//rotating the object by given values
    }
}
