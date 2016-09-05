using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public Rigidbody rb;
    public float speed;
    public Vector3 PlayerPos;

    void Start()
    {
        // Auto detects the rigidbody attatched to the player(may be unnecessary)
        rb = GetComponent<Rigidbody>();
}

    void FixedUpdate()
    {
        // Gives the player a constant forward velocity
        transform.position += new Vector3(0, 0f, speed * Time.deltaTime);

        // Creates a lane change and will be changed to swipe input
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        { 
            transform.position += new Vector3(-10f, 0f, 0f);
        }
   
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
     
            transform.position += new Vector3(10f, 0f, 0f);
        }
}     
        // Unneeded function(Unneeded at the moment)
    void Update()
    {

    }
    // Working print, will lead to scene load of the game over
    void OnCollisionEnter(Collision collision)
    {
        print("Game Over");
    }
    
}