using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public bool Hit=false;
	public int MaxPoints;
	public int Points;
	public int DamageAmount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Hit == true) {
			Points -= DamageAmount;
			Hit = false;
		}

		if (Points == 0) {
			Destroy (this.transform.gameObject);
		}
	}
}
