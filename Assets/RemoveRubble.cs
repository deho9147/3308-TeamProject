using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** waits for a while to remove destroyed objects rubble*/
public class RemoveRubble : MonoBehaviour {
	private int counter = 0;
	void Update()
	{
			counter ++;
			if (counter > 369){
				Destroy(gameObject);
			}
	}
}

