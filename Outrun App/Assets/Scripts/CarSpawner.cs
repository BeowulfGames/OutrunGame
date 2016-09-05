using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

    // Stores the cars for creating
    public GameObject Car1;
    // Gives a standard rotation to allign everything correctly
    private Quaternion rotation = Quaternion.Euler(0, 90, 0);
    // Creates an array to keep track of how many cars are in scene
    GameObject[] Cars;
    // Creates the varies position for different lanes
    private Vector3 CarPositionL1;
    private Vector3 CarPositionL2;
    private Vector3 CarPositionL3;
    private Vector3 CarPositionL4;
    private Vector3 CarPositionL5;
    // Random int to vary the car lane placement
    private int Position;
    // Random int to vary the distance between cars
    private int Distance;
    // Used to compare zeds 
    private Vector3 HighwayPosition;
    // Bring the highway game object to destroy(May not need)
    public GameObject Highway;
    // Needed player reference to compare depth
    public GameObject Player;
    private int x;

    public float ThymeDestroy;
    public int TimerDestroy = 60;

	// Use this for initialization
	void Start ()
    {

        // Creates a base for the cars to be instantiated
        CarPositionL1 = new Vector3(-20, 5, 100);
        CarPositionL2 = new Vector3(-10, 5, 100);
        CarPositionL3 = new Vector3(0, 5, 100);
        CarPositionL4 = new Vector3(10, 5, 100);
        CarPositionL5 = new Vector3(20, 5, 100);

    }
    	
	// Update is called once per frame
	void Update () {

        x = Random.Range(0, 10);
        // Creates an array of the cars in the game, excluding the player
        Cars = GameObject.FindGameObjectsWithTag("Car");

        // Sees if there needs to be more cars
        if (x > 10)
        {
            InstantiateCar();
            x += 1;
        }

        ThymeDestroy += Time.deltaTime;

        Entropy();
        
	}

    // Function to create cars and reassign the position, so instantiating doesn't cause overlap
    void InstantiateCar() {
        // Assigns random ints to determing lane and distance between cars respectively
        Position = Random.Range(1,5);
        Distance = Random.Range(200, 300);
        // Actual Switch to determien where things are placed
        switch (Position)
        {
            case 1:
                Instantiate(Car1, CarPositionL1, rotation);
                CarPositionL1.z += Distance;
                break;
            case 2:
                Instantiate(Car1, CarPositionL2, rotation);
                CarPositionL2.z += Distance;
                break;
            case 3:
                Instantiate(Car1, CarPositionL3, rotation);
                CarPositionL3.z += Distance;
                break;
            case 4:
                Instantiate(Car1, CarPositionL4, rotation);
                CarPositionL4.z += Distance;
                break;
            case 5:
                Instantiate(Car1, CarPositionL5, rotation);
                CarPositionL5.z += Distance;
                break;
        }   
    }

    void Entropy()
    {
        if (ThymeDestroy >= TimerDestroy)
        {
            Destroy(gameObject);
            TimerDestroy += 60;
        }
    }
}
