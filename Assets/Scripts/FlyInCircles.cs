using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyInCircles : MonoBehaviour {

    // Use this for initialization
    private Vector3 offset;
    private int Transformer;
    private int count;
    private float speed = 60.5f;

    // Update is called once per frame
    void Update(){
        gameObject.transform.Rotate(0,.5f,0);
        gameObject.transform.position += gameObject.transform.forward * Time.deltaTime * speed;
    }
}