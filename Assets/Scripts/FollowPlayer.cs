using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float speed;
    //allows other scripts to regonize the name for this script. player = PlayerController script.
    public GameObject player;
    //create a variable for the camera's offset, so its position wont be inside the player.
    Vector3 offset = new Vector3(0,5,-10);


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        allows the gameObject to have the same (x,y,z) cords. 
        be careful when using this, otherwise the cam will
        be inside whichever object you selected. 
        transform.position = player.transform.position + offset;
        transform.Translate(Vector3.forward * speed);
        if(player == null)
        {
            speed = 0;
        }
        */
    }
    void LateUpdate()
    {
         /*allows the gameObject to have the same (x,y,z) cords. 
        be careful when using this, otherwise the cam will
        be inside whichever object you selected. */
        transform.position = player.transform.position + offset;
        transform.Translate(Vector3.forward * speed);
        if(player == null)
        {
            speed = 0;
        }
    }
}
