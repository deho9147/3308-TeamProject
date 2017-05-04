using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/** 
 * make an object move towards the a specific location
 * the goal location was the player
 * this was unused in the final project
 */
public class Towardsplayerscript : MonoBehaviour {
    public Transform playerLoc;

	void Update(){
        transform.GetComponent<NavMeshAgent>().destination = playerLoc.position;
	}
}
