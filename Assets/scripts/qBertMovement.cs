using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class qBertMovement : MonoBehaviour {

	//these variable names are very confusing. 
	//maybe shootProbability, isTurning, turnProbability
	
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

		//Does it collide? don't use translate
		
		transform.Translate(Vector3.forward * Time.deltaTime);	


		// find a way to clean up the probability with some public variables
		//very hard to tune something like this
		
		if (shootTurnNumber <= likelyToShoot) {
			//shoot!
			Instantiate (bullet, transform.position, transform.rotation);
			//might as well be 0.
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
			//use time.deltaTime so higher framerates won't make them shoot faster
			
			likelyToShoot += 0.0002f;
		}
	}

	void OnCollisionEnter () {
		
		//if you're doing redirection code in both update and OnCollision, write a function for it
		
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
		
		//why is the probability set back to a higher value (0.1) here than in Update?
		//make a function for this as well. Re-use the function
		
		if (shootTurnNumber <= likelyToShoot) {
			//shoot!
			Instantiate (bullet, transform.position, transform.rotation);
			likelyToShoot = 0.1f;
		} else {
			likelyToShoot += 0.1f;
		}
	}
}
