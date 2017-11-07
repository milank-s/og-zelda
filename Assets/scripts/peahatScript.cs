using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peahatScript : MonoBehaviour {

	float whichDirection;
	float howLongToFly;
	int restCounter = 0;
	int flyingCounter = 0;
	bool readyToTurn = false;
	bool isFlying = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (isFlying == false) {
			restCounter++;
			if (restCounter >= 60) {
				isFlying = true;
			}
		}

		if (isFlying == true && readyToTurn == false) {
			restCounter = 0;
			flyingCounter++;
			if (flyingCounter >= 60) {
				readyToTurn = true;
			}
			if (transform.position.y < 5) {
				transform.position = new Vector3 (transform.position.x, transform.position.y + 0.05f, transform.position.z);
			}

			transform.Translate ((Vector3.forward)/20f);

		}


		if (readyToTurn == true && isFlying == true) {
			whichDirection = Random.Range (0f, 0.99f);
			flyingCounter = 0;

			if (whichDirection <= 0.124f) {
				transform.rotation = Quaternion.Euler (0f, 45f, 0f); 
			}
			if (whichDirection <= 0.249f && whichDirection > 0.124f) {
				transform.rotation = Quaternion.Euler (0f, 90f, 0f);
			}
			if (whichDirection <= 0.374f && whichDirection > 0.249f) {
				transform.rotation = Quaternion.Euler (0f, 135f, 0f);
			}
			if (whichDirection <= 0.449f && whichDirection > 0.374f) {
				transform.rotation = Quaternion.Euler (0f, 180f, 0f);
			}
			if (whichDirection <= 0.624f && whichDirection > 0.449f) {
				transform.rotation = Quaternion.Euler (0f, 225f, 0f);
			}
			if (whichDirection <= 0.749f && whichDirection > 0.624f) {
				transform.rotation = Quaternion.Euler (0f, 270f, 0f);
			}
			if (whichDirection <= 0.874f && whichDirection > 0.749f) {
				transform.rotation = Quaternion.Euler (0f, 315f, 0f);
			}
			if (whichDirection > 0.874f) {
				transform.rotation = Quaternion.Euler (0f, 0f, 0f);
			}
			readyToTurn = false;
		}


	}


}
