using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Turns an object into destroyed rubble. Specifically applies to buildings or large structures.
 */
public class DestructionControl : MonoBehaviour {

	/**
	 * The object to be used as rubble. To be set in the Unity editor.
	 */
	public GameObject rubble;
	
	/**
	 * At each frame, if a trigger occurs, create the rubble object and destroy this.
	 */
	void Update(){
		if(Input.GetKey(KeyCode.Space)){
			Instantiate(rubble, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}
