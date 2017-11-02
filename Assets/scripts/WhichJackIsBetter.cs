using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhichJackIsBetter : MonoBehaviour {

	bool jackT = false;
	bool jackG = false;
	float numberRand;

	// Use this for initialization
	void Start () {
		numberRand = Random.Range (0f, .99f);
	}
	
	// Update is called once per frame
	void Update () {
		if (numberRand <= 0.49f) {
			jackT = true;
			Debug.Log ("Jack T is better");
		} else {
			jackG = true;
			Debug.Log ("Jack G is better");
		}
	}
}
