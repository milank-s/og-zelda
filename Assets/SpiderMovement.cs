using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour {
    Rigidbody rb;
    public float minDistance;
    public float maxDistance;

    float timer;
    public float timerMin;
    public float timerMax;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        timer = 1;
	}
	
	// Update is called once per frame
	void Update () {
        if (timer < 0) {

            //direction is in 45 degree angles
            //distance is random multiplyer 
            //height is set
            //
            rb.MovePosition(transform.position+ new Vector3(transform.position.x+ Random.Range());




            timer = Random.Range(timerMin, timerMax);
        }
	}


    int RoundToNearest45(float degree) {
        return (int)Mathf.Round(degree / 45) * 45;
    }
}
