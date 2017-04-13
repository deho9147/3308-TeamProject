using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyInCircles : MonoBehaviour {

    // Use this for initialization
    private Vector3 offset;
    public GameObject Player;
    private int Transformer;
    private int count;
    private float speed = 60.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,.5f,0);
       transform.position += transform.forward * Time.deltaTime * speed;
    }
}