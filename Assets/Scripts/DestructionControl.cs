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
	public int health = 3;
	
	/**
	 * When other object is struck by object defined by col.gameObject.name, creates rubble 
	 */
	 
	
	void OnCollisionEnter(Collision col)
	{
			if(col.gameObject.name == "jeep")
			{
				health--;
			}
			if(col.gameObject.name == "jeep" && health == 1)
			{
				rubble.transform.localScale = 0.125f*(gameObject.transform.localScale);
				Instantiate(rubble, transform.position, transform.rotation);
				Destroy(col.gameObject);
				Destroy(gameObject);
				Destroy(rubble);
			}
	}
	
	/** Used to test destroying objects by just pressing the space bar*/
	
	/**void Update () {
 		if(Input.GetKey(KeyCode.Space)){
 			Instantiate(rubble, transform.position, transform.rotation);
 			Destroy(gameObject);
 	}
 	}
	*/
}
