using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Behavior that forces the object to move between points in a cycle.
 */
public class FollowPath : MonoBehaviour {

    public Transform[] path;        /**< A list of locations for this object to move between. The last point will be linked to the first one.*/
    public float speed = 6.0f;      /**< The speed for this object to move at. */
    public float near = 1.0f;       /**< How close the object needs to be to a point before it can move on. If this is too small compared to speed, it may bounce back and forth on a point in the path. */
    
    private int currentpoint = 0;

    /**
     *  When the scene is loaded, rotates this object toward the first point in the path.
     */
	void Start(){
        transform.LookAt(path[currentpoint]);
    }

    /**
     * Every frame, moves this object closer to the next point in the path. If it gets close enough (as specified by near), it looks for the next point ini the path.
     */
	void Update(){
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

    /**
     * Helper that draws the path in the Unity editor to more easily see movement.
     */
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
