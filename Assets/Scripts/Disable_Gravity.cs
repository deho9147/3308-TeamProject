using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disable_Gravity : MonoBehaviour {
	
	// Update is called once per frame
	void Start () {
		No_Gravity ();
	}

	void Update () {
		No_Gravity ();
	}

	/**
	 * Turns of gravity for this object.
	 */
	public void No_Gravity() {
		gameObject.GetComponent<Rigidbody>().useGravity = false;
	}
}
