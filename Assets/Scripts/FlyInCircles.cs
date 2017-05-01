using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Behavior that forces an object to move in circles.
 */
public class FlyInCircles : MonoBehaviour {

    private Vector3 offset;
    private float speed = 60.5f;

    /**
     * Changes the position and rotation of the object every frame.
     */
    void Update(){
        gameObject.transform.Rotate(0,.5f,0);
        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * speed;
    }
}