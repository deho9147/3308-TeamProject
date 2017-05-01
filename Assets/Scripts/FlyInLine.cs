using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Behavior that forces an object to move in straight lines in a pattern.
 */
public class FlyInLine : MonoBehaviour {

    private Vector3 offset;
    private int transformer;
    private int count;
    private float speed = .5f;

    /**
     * When the scene is loaded, Start is called to reset the pattern.
     */
    void Start(){
        offset = new Vector3(1,1,1);
        count = 0;
    }

    /**
     * Each frame, move forward a speed. Will change direction every 100 frames.
     */
    void Update(){
        if (count == 100){
            transformer = 1;
        }
        else if (count == 200){
            transformer = -1;
            count = 0;
        }
        gameObject.transform.position = gameObject.transform.position + offset*transformer*speed;
        count = count + 1;
    }
}