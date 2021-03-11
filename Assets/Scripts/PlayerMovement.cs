using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]float Speed = 2f;//giving values for speed
    [SerializeField] GameObject maincam; // creating a gamobject called cam
    public float camSensitivity = 1f;//giving values for camera Sensitivity



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        playermovement();//calling a function
        cam();//calling a cam function
    }

    void playermovement()
    {
        if (Input.GetKey(KeyCode.W))//getting input key
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);//asking to move on the given direction
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);//asking to move on the given direction
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);//asking to move on the given direction
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);//asking to move on the given direction
        }
    }

    void cam()

    {
        float mouse_x = Input.GetAxis("Mouse X");//getting input of mouse
        float mouse_y = Input.GetAxis("Mouse Y");//getting input of mouse

        Vector3 rotY = transform.eulerAngles;//eulerangle is used to rotate in world space
        rotY.y += mouse_x * camSensitivity;//multiplying x value with camera sensitivity
        transform.localRotation = Quaternion.AngleAxis(rotY.y, Vector3.up);// creates a new rotation with degress of x and y axis

        Vector3 rotX = maincam.gameObject.transform.localEulerAngles;
        rotX.x -= mouse_y * camSensitivity;//multiplying y value with camera sensitivity
    }
}
