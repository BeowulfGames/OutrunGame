using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour {

    // will allow different speed for varied cars
    public float CarSpeed;
    // public new Vector3 position;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // position = Transform.position

        // Will check if the object is behind the player and then destroy
        Destroyer();
	}
    // Will destroy the gameobject
    void Destroyer()
    {
        
    }
}
