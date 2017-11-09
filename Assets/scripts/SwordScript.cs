using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour {

	public GameObject Victim;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider col){
		//This will cause null reference error if the collided object doesn't have health (a wall for example)
		//check if GetComponent<Health>() is null before trying to access it
		//you also don't need to keep track of a Victim variable. Just have a local variable in this function
		
		Victim = col.gameObject;
		Victim.GetComponent<Health> ().Points--;
	}
}
