using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public bool Hit=false;
	public int Points;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Hit == true) {
			Points -= 1;
			Hit = false;
		}

		if (Points == 0) {
			Destroy (this.transform.gameObject);
		}
	}
}
