using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

	public int Damage;

	// Use this for initialization
	void Start () {
		Damage = 1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward *5* Time.deltaTime);	
	}

	void OnTriggerEnter (Collider Col) {
		if (Col.name == "Player") {
			Col.GetComponent<Health> ().DamageAmount = Damage;
			Col.GetComponent<Health> ().Hit = true;
		}
		Destroy (gameObject);
	}
}
