using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Check the left and right arrow keys
		if(Input.GetAxis("Horizontal") < 0)
		{
			// Then move to the left
			//Debug.Log("Going left.");
			transform.Translate(new Vector3(-2, 0, 0) * Time.deltaTime);
		}
		else if(Input.GetAxis("Horizontal") > 0)
		{
			// Then move to the right
			//Debug.Log("Going right.");
			transform.Translate(new Vector3(2, 0, 0) * Time.deltaTime);
		}
		else if(Input.GetAxis("Vertical") < 0)
		{
			// Then move to the right
			//Debug.Log("Going right.");
			transform.Translate(new Vector3(0, -2, 0) * Time.deltaTime);
		}
		else if(Input.GetAxis("Vertical") > 0)
		{
			// Then move to the right
			//Debug.Log("Going right.");
			transform.Translate(new Vector3(0, 2, 0) * Time.deltaTime);
		}		
	}
}
