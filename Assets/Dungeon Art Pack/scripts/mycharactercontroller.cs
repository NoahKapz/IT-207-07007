using UnityEngine;
using System.Collections;

public class mycharactercontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.zero;

		// Is Up pressed?
		if (Input.GetKey (KeyCode.UpArrow) == true) {
		//Move Character up by some amount
		direction.y += 0.1f;
	}
	//Is Left pressed?
		// Move Character left by some amount
	if (Input.GetKey (KeyCode.LeftArrow) == true) {
		// Move character left by some amount
		direction.x -= 0.1f;
	}
	// Is Right pressed?
		// Move character right by some amount
		if (Input.GetKey (KeyCode.RightArrow) == true) {
		// Move Character right by some amount
			direction.x += 0.1f;
		}
	// Is Down pressd?
		// Move character down by some amount
		if (Input.GetKey (KeyCode.DownArrow) == true) {
		// move character down by some amount
		direction.y -= 0.1f;
	}
	gameObject.transform.Translate (direction);

	}
}
