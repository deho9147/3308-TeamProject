using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructionControl : MonoBehaviour {

	public GameObject rubble;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
			Instantiate(rubble, transform.position, transform.rotation);
			Destroy(gameObject);
		}
	}
}
