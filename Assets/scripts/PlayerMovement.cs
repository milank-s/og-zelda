using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public bool ShieldUp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			this.GetComponent<Transform>().eulerAngles=new Vector3 (0,-90,0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
		} else if (Input.GetKey(KeyCode.W)){
			this.GetComponent<Transform>().eulerAngles=new Vector3 (0,0,0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
		} else if (Input.GetKey(KeyCode.S)){
			this.GetComponent<Transform>().eulerAngles=new Vector3 (0,180,0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
		} else if (Input.GetKey(KeyCode.D)){
			this.GetComponent<Transform>().eulerAngles=new Vector3 (0,90,0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
		} 

		if (Input.GetKey (KeyCode.U)) {
			ShieldUp = true;
		} else if (Input.GetKeyUp (KeyCode.U)){
			ShieldUp = false;
		} else if(Input.GetKeyDown.O)){
			//will put sword attack script in here once health script and attack function are coded
		}


	}
}
