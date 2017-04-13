using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyInLine : MonoBehaviour {

    // Use this for initialization
    private Vector3 offset;
    public GameObject Player;
    private int Transformer;
    private int count;
    private float speed = .5f;
    void Start()
    {
        offset = new Vector3(1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        if (count == 100){
            Transformer = 1;
        }
        else if (count == 200){
            Transformer = -1;
            count = 0;
        }
            transform.position = Player.transform.position + offset*Transformer*speed;
            count = count + 1;
    }
}