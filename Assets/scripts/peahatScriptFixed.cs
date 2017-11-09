using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peahatScriptFixed : MonoBehaviour {

	public float flyingCounter = 0f;
	float turnCounter = 0f;
	public bool isFlying = false;
	bool readyToLand = false;


	void Update () {
		//flying counter always increases
		flyingCounter += Time.deltaTime / 10;

		//when flying counter gets great enough, ready to fly
		if (flyingCounter >= 60 * Time.deltaTime) {
			isFlying = true;
		}

		//rises when ready to fly
		if (isFlying == true && transform.position.y < 5f) {
			transform.position = new Vector3 (transform.position.x, transform.position.y + 0.05f, transform.position.z);
		}

		//runs in a 10 second or so cycle
		if (flyingCounter >= 200 * Time.deltaTime) {
			isFlying = false;
		}

		//if we've reached our terminal height
		if (isFlying == true && transform.position.y >= 5f) {
			
			//go forward
			transform.Translate ((Vector3.forward)/20f);

			//turn counter rises
			turnCounter += Time.deltaTime;
		}

		//falls when no longer flying
		if (isFlying == false && transform.position.y >= 1.5f) {
			transform.position = new Vector3 (transform.position.x, transform.position.y - 0.05f, transform.position.z);
			flyingCounter = 0f;
		}

		//turning while in the air
		if (turnCounter >= 80 * Time.deltaTime) {

			//random number float to decide which direction
			float whichDirection = Random.Range (0f, 0.99f);
			if (whichDirection <= 0.124f) {
				transform.rotation = Quaternion.Euler (0f, 45f, 0f); 
			} else if (whichDirection <= 0.249f && whichDirection > 0.124f) {
				transform.rotation = Quaternion.Euler (0f, 90f, 0f);
			} else if (whichDirection <= 0.374f && whichDirection > 0.249f) {
				transform.rotation = Quaternion.Euler (0f, 135f, 0f);
			} else if (whichDirection <= 0.449f && whichDirection > 0.374f) {
				transform.rotation = Quaternion.Euler (0f, 180f, 0f);
			} else if (whichDirection <= 0.624f && whichDirection > 0.449f) {
				transform.rotation = Quaternion.Euler (0f, 225f, 0f);
			} else if (whichDirection <= 0.749f && whichDirection > 0.624f) {
				transform.rotation = Quaternion.Euler (0f, 270f, 0f);
			} else if (whichDirection <= 0.874f && whichDirection > 0.749f) {
				transform.rotation = Quaternion.Euler (0f, 315f, 0f);
			} else {
				transform.rotation = Quaternion.Euler (0f, 0f, 0f);
			}
			//resets turn counter
			turnCounter = 0f;
		}


	}
}
