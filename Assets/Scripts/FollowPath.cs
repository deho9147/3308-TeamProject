using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPath : MonoBehaviour {

    // Use this for initialization
    public Transform[] path;
    public float speed = 6.0f;
    public float near = 1.0f;
    public int currentpoint = 0;
	void Start () {
        transform.LookAt(path[currentpoint]);

    }
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(path[currentpoint].position, transform.position);
        transform.position = Vector3.MoveTowards(transform.position,path[currentpoint].position,Time.deltaTime*speed);
        if (dist <= near)
        {
            currentpoint++;
            if (currentpoint >= path.Length)
            {
                currentpoint = 0;
            }
            transform.LookAt(path[currentpoint]);
        }
	}

    void OnDrawGizmos(){
        if (path.Length > 0){
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] != null)
                {
                    Gizmos.DrawSphere(path[i].position, near);
                }
            }
        }
    }
}
