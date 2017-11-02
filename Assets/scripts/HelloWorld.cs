using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("SayHelloWorld");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SayHelloWorld(){
		Debug.Log("Hello world!");
		yield return null;
	}
}
