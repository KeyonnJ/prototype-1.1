using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
 public float speed;


    //void start only calls up on the code for the first frame, no other frames. single use.
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    //void update is used for code that should run every frame rather than only once on the first frame like void start.
    void Update()
    {
        //code used to move the 3d object(vehicle) forward at a constant rate.
        /*
        transform.Translate(0,0,0.1);
        */

        //unity have a unique way to identify cordinates, in this scenario, vector3.
        /* with vector3, untiy automatically identifies x,y, and z paths
        as either up or down(y), left or right(x) and forward or backwards(z)
        this allows coders to efficently create logic with unity via vector3.
        vector2 and 3 should mainly be used in void update, otherwise it wont run every frame as it should.
        */ 
        transform.Translate(Vector3.forward * speed);
        /*Time.deltaTime uses time intervals to act as a timer for 
        code in void update, that way insead of running every frame,
        it should run in different time intervals.
        notice how we are multiplying though, this allows the forward code
        to be multiplied by low time numbers to slow down objects.
        */
        //Input.GetKey allows the player to hold a specific key for the following code to function.
        //theres also Input.GetKeyDown, which only triggers once if the player inputs the key.
        if(Input.GetKey(KeyCode.D))

        {
            transform.position += Vector3.right * speed;
        }
        if(Input.GetKey(KeyCode.A))

        {
            transform.position += Vector3.left * speed;
        }
        if(Input.GetKey(KeyCode.W))

        {
            transform.position += Vector3.up * speed;
        }
        
    }
    //OnCollisionEnter allows collisions to be identified if your game object collides with another game object.
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("obstacle"))
        {
            Destroy(gameObject);
        }





    }
}
