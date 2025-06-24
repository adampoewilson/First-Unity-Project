using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Script : MonoBehaviour
{

    public Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            // Vector2.up is short for moving y
            // coordinate up 1
            myRigidBody.velocity = Vector2.up * 10;
        
        }
    }
}
