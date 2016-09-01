using UnityEngine;
using System.Collections;

public class CarSpawner : MonoBehaviour {

    private int CarP1;
    public GameObject Car1;
    public Quaternion rotation = Quaternion.Euler(0, 90, 0);
    private Vector3 Car1Position;
    private Vector3 CarPosition;
    private int CarStart;
    private int NumCars;
    GameObject[] Cars;

	// Use this for initialization
	void Start () {

        // Determines how many cars will be created
        CarStart = Random.Range(0, 4);

        // Creates a base for the cars to be instantiated
        CarPosition = new Vector3(0, 5, 100);

        // For loop for creating the cars at the start and reassigns the position, for future the reassign position will be in a function
        for (int i = CarStart; i>0; i--)
        {
            Instantiate(Car1, CarPosition, rotation);
            CarPosition = new Vector3(0, 0, +50);
        }
      
                
        }
    	
	// Update is called once per frame
	void Update () {

        // Creates an array of the cars in the game, excluding the player
        Cars = GameObject.FindGameObjectsWithTag("Car");

        // Sees if there needs to be more cars
        if (Cars.Length < 3)
        {
            Instantiate();
        }
	}

    // Function to create cars and reassign the position, so instantiating doesn't cause overlap
    void Instantiate()
    {
        Instantiate(Car1, CarPosition, rotation);
    }

    // May have this destroy cars behind the player, undecided
    void Destroyer()
    {

    }
}
