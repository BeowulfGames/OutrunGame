using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    public bool GameOver = false;
    public Rigidbody rb;
    public float speed;

    void Update()
    {
        // Auto detects the rigidbody attatched to the player(may be unnecessary)
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Gives the player a constant forward velocity
        transform.position += new Vector3(0, 0f, 100 * Time.deltaTime);

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
 

    // Eventually will display the game over function(Have no idea how to work that)
    /* void OnCollisionEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Car")
        {
            print("crash)");
        }
    }
    */
}