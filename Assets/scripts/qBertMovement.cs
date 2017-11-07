using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qBertMovement : MonoBehaviour {

	float directionChangeNumber;
	float shootTurnNumber;
	float likelyToShoot = 0.1f;
	bool turnYes = false;
	public Transform bullet;
	//moves once between 3-5 seconds
	//shoots between 1-10 turns
	//blue takes 2 hits, orange takes 1


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		shootTurnNumber = Random.Range (0f, 0.99f);

		transform.Translate(Vector3.forward * Time.deltaTime);	



		if (shootTurnNumber <= likelyToShoot) {
			//shoot!
			Instantiate (bullet, transform.position, transform.rotation);
			likelyToShoot = 0.0002f;
			directionChangeNumber = Random.Range (0f, 2.99f);
			if (directionChangeNumber <= 0.99f) {
				transform.rotation = Quaternion.Euler (0, transform.rotation.y + 90, 0);
			} else if (directionChangeNumber <= 1.99f && directionChangeNumber > 0.99f) {
				//one third of the time turn to the left
				transform.rotation = Quaternion.Euler (0, transform.rotation.y - 90, 0);
			} else {
				//one third of the time turn completely around
				transform.rotation = Quaternion.Euler (0, transform.rotation.y + 180, 0);
			}
		} else {
			likelyToShoot += 0.0002f;
		}
	}

	void OnCollisionEnter () {
		//number to decide change of direction
		directionChangeNumber = Random.Range (0f, 2.99f);

		//number to decide if we shoot or not
		//one third of the time turn to the right
		if (directionChangeNumber <= 0.99f) {
			transform.rotation = Quaternion.Euler (0, transform.rotation.y + 90, 0);
		} else if (directionChangeNumber <= 1.99f && directionChangeNumber > 0.99f) {
			//one third of the time turn to the left
			transform.rotation = Quaternion.Euler (0, transform.rotation.y - 90, 0);
		} else {
			//one third of the time turn completely around
			transform.rotation = Quaternion.Euler (0, transform.rotation.y + 180, 0);
		}
		if (shootTurnNumber <= likelyToShoot) {
			//shoot!
			Instantiate (bullet, transform.position, transform.rotation);
			likelyToShoot = 0.1f;
		} else {
			likelyToShoot += 0.1f;
		}
	}
}
