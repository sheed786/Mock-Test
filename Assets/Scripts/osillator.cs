using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osillator : MonoBehaviour
{
    Vector3 Startingposition;//giving  a start position
    [SerializeField]Vector3 movementVector;
    float movementFactor;

    [SerializeField] float period = 2f;//setting  a period value
  


    // Start is called before the first frame update
    void Start()
    {
        Startingposition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if  (period <= Mathf.Epsilon)//getting the least value and return null
        {
            return;
        }
        float cycle = Time.time / period; //continuously growing over time

        const float tau = Mathf.PI * 2; // tau constant value of 6.28
        float rawSinWave = Mathf.Sin(cycle * tau); // value growing from -1 to 1

        movementFactor = (rawSinWave + 1f) / 2f; // rearranging values from 0 to 1  

        Vector3 offset = movementVector * movementFactor;//calculating two movement values
        transform.position = Startingposition + offset;//getting the current position
    }
}




    
