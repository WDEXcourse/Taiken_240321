using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0, 0, speed);
        }


    }


}
