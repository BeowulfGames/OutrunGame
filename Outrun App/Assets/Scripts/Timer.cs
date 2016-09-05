using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    // Float is the storage for the time
    public float A;
    // Int is the casted time
    public int B;
    // Text to display score
    public Text Score;
     
    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Makes A constantly change according to the change in time
	    A += Time.deltaTime;
        // Cast to make the score prettier
        B = (int)A;
        // Display of the Score as an int
        Score.text = "Score: " + B.ToString();
	}
}
