using UnityEngine;
using System.Collections;

public class HighwayManager : MonoBehaviour {
    // Brings the object for instantiation
    public GameObject Highway;
    // An array to keep track of how much road is in scene
    GameObject[] Road;
    // Creates standard position and rotation for the instantiation
    public Vector3 position = new Vector3(0,0,0);
    private Quaternion rotation = Quaternion.Euler(0, 90, 0);
    private int TimerHighway;
    private float ThymeHighway;

	// Use this for initialization
	void Start () {

        RoadBuilder();
	}
	
	// Update is called once per frame
	void Update () {
        // Fills an array with the road game objects
        Road = GameObject.FindGameObjectsWithTag("Highway");
        ThymeHighway += Time.deltaTime;

        // Creates new road if there is less than two sections
        if (Road.Length <= 3)
        {
            RoadBuilder();
        }

	}

    // Function that creates new road and reassigns the zed to avoid overlap
    void RoadBuilder()
    {

        if (TimerHighway - ThymeHighway <= 5)
        {
            Instantiate(Highway, position, rotation);
            position.z += 1000;
            TimerHighway += 30;
        }
        else
        {
            Instantiate(Highway, position, rotation);
            position.z += 1000;
        }
        
        
    }
}
