using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PlayerController for a 2.5D perspective view
//Assumptions: Main camera is a child of the player object, and oriented at the desired angle of view
public class TwoAndAHalf_PlayerController : MonoBehaviour
{
    //In this kind of player controller, we dont worry about rotation and only have movement speed and jump strength
    public float movementSpeed = 1.0f;
    public float jumpStrength = 1.0f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //=======Lateral movement==========
        MovePlayer();
        //======Jumping========
        Jump();
    }

    void MovePlayer()
    {
        //like before, use key pressed to assign a velocity
        //notably, directions for each key are assigned differently due to the non-first person view
        Vector3 direction = new Vector3(0, 0, 0);
        float y = rb.velocity.y;

        if (Input.GetKey(KeyCode.D))
        {
            direction += transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction -= transform.forward;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direction -= transform.right;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += transform.right;
        }

        Vector3 velocity = direction.normalized * movementSpeed;
        velocity.y = y;
        rb.velocity = velocity;
    }

    void Jump()
    {
        //When the Space bar is pressed, set a positive velocity
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, jumpStrength, 0);
        }
    }
}
