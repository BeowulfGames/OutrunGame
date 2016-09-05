using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    // Allows different speed for varied cars
    public float CarSpeed;
    public GameObject Player;

    // public new Vector3 position;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Gives the Cars a constant forward velocity
        transform.position += new Vector3(0, 0f, CarSpeed * Time.deltaTime);

        // Used to destroy cars behind the player
        if (transform.position.z < Player.transform.position.z)
        {
            Destroy(gameObject);
        }
	}

    
}
