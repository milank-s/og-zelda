using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	
	public int Damage;

	// Use this for initialization
	void Start () {
		//you're overwriting the damage value you set in the inspector here. 
		//either make the variable private and set it in code, or public and set it in the inspector
		Damage = 1;
	}
	
	// Update is called once per frame
	void Update () {
		//it would help for tuning the speed to have a public bulletspeed variable 
		transform.Translate(Vector3.forward *5* Time.deltaTime);	
	}

	void OnTriggerEnter (Collider Col) {
		if (Col.name == "Player") {
			//instead of setting a bool to change the health, just make changes to the player's health here
			//OR call a function in health to take the damage. Easier, doesn't need to keep track of a bool. 
			
			Col.GetComponent<Health> ().DamageAmount = Damage;
			Col.GetComponent<Health> ().Hit = true;
		}
		Destroy (gameObject);
	}
}
