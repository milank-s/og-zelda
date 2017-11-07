using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMovement : MonoBehaviour {
    Rigidbody rb;
    public float minDistance;
    public float maxDistance;
    public float minSpeed;
    public float maxSpeed;
    float timer;
    public float timerMin;
    public float timerMax;
    float moveTime;
    Vector3 dir;
    float force;
    bool moveSet;
    bool moving;
    float jumpUp;
    public float jumpHeight;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        timer = 1;
        float moveTime = Random.Range(minDistance, maxDistance);
    }
	
	// Update is called once per frame
	void Update () {
        if (timer < 0) {
            moveSet = true;
            timer = Random.Range(timerMin, timerMax);

        }
        if (moveSet) {
            dir = Random.insideUnitSphere;
            force = Random.Range(minSpeed, maxSpeed);
            moveTime = Random.Range(minDistance, maxDistance);
            jumpUp = moveTime / 2;
            moveSet = false;
        }
        if (moveTime > 0) {
            moving = true;
            if (moveTime > jumpUp) {
                rb.MovePosition(transform.position + new Vector3(dir.x, 0, dir.z) * force * Time.deltaTime + new Vector3(0, jumpHeight * Time.deltaTime, 0));

            }
            else {
                rb.MovePosition(transform.position + new Vector3(dir.x, 0, dir.z) * force * Time.deltaTime);
            }

            moveTime -= Time.deltaTime;
        }
        else {
            timer -= Time.deltaTime;
            
        }
       
        
	}


    int RoundToNearest45(float degree) {
        return (int)Mathf.Round(degree / 45) * 45;
    }
}
