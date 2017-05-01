using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Towardsplayerscript : MonoBehaviour {
    public Transform playerLoc;

	void Update(){
        transform.GetComponent<NavMeshAgent>().destination = playerLoc.position;
	}
}
