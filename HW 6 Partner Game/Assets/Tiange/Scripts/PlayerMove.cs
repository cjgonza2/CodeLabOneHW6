using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    
    private static float moveSpeed;
    private Rigidbody Rb;

    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 5f;

        Rb = GetComponent<Rigidbody>();
        //disable capsule's rotation
        Rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        //xpos
        Move(KeyCode.A, -moveSpeed,0,0);
        Move(KeyCode.D, moveSpeed,0,0);

        //ypos
        Move(KeyCode.Space, 0, moveSpeed, 0);

        //zpos
        Move(KeyCode.W, 0,0, moveSpeed);
        Move(KeyCode.S, 0,0, -moveSpeed);

        
    }

    //player movement function
    void Move(KeyCode key, float xMove, float yMove,float zMove) 
    {
        if (Input.GetKey(key))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(xMove, yMove, zMove);
        }
       
    }

   //trying to figure out how to move and jump at the same time
}
