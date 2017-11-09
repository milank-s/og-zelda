using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public bool ShieldUp;
	public GameObject Victim;

	public GameObject Sword;
	public bool HasSword=true;
	public bool IsAttacking = false;

	public Vector3 SwordOut;
	public Vector3 SwordIn=new Vector3 (0,0,0);
	public Vector3 moveDir;
	public bool IsSwordIn=true;

	public enum PlayerStates{
		Idle,
		Moving,
		Attacking,
		Blocking,
		Dead
	}

	public PlayerStates myCurrentState=PlayerStates.Idle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			this.GetComponent<Transform> ().eulerAngles = new Vector3 (0, -90, 0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
			myCurrentState = PlayerStates.Moving;
		} else if (Input.GetKey (KeyCode.W)) {
			this.GetComponent<Transform> ().eulerAngles = new Vector3 (0, 0, 0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
			myCurrentState = PlayerStates.Moving;
		} else if (Input.GetKey (KeyCode.S)) {
			this.GetComponent<Transform> ().eulerAngles = new Vector3 (0, 180, 0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
			myCurrentState = PlayerStates.Moving;
		} else if (Input.GetKey (KeyCode.D)) {
			this.GetComponent<Transform> ().eulerAngles = new Vector3 (0, 90, 0);
			transform.Translate (0f, 0f, 5f * Time.deltaTime);
			myCurrentState = PlayerStates.Moving;
		} else if (Input.GetKeyUp (KeyCode.A)) {
			myCurrentState = PlayerStates.Idle;
		} else if (Input.GetKeyUp (KeyCode.W)) {
			myCurrentState = PlayerStates.Idle;
		} else if (Input.GetKeyUp (KeyCode.S)) {
			myCurrentState = PlayerStates.Idle;
		} else if (Input.GetKeyUp (KeyCode.D)) {
			myCurrentState = PlayerStates.Idle;
		}

		Ray Direction=new Ray(transform.position, transform.forward);

		float maxRayDist = 1.0f;

		Debug.DrawRay (Direction.origin, Direction.direction, Color.black, maxRayDist);


		if (Input.GetKey (KeyCode.U)) {
			ShieldUp = true;
			myCurrentState = PlayerStates.Blocking;
		} else if (Input.GetKeyUp (KeyCode.U)){
			ShieldUp = false;
			myCurrentState = PlayerStates.Idle;
		} else if(Input.GetKeyDown(KeyCode.O)){
			//will put sword attack script in here once health script and attack function are coded
			if (HasSword==true){
				myCurrentState = PlayerStates.Attacking;
			}
		}

		if (myCurrentState==PlayerStates.Attacking) {
			if (IsSwordIn == true) {
//				moveDir = SwordOut - SwordIn;
//				if (moveDir.magnitude > .1f) {
//					moveDir = Vector3.Normalize (moveDir);
//					moveDir.z = moveDir.z * .1f;
//				}
//				Sword.transform.localPosition += moveDir * Time.deltaTime * 5.0f;

				Sword.GetComponent<Transform> ().localPosition = SwordOut;
				IsSwordIn = false;

			} else if (IsSwordIn == false) {
//				moveDir = -SwordOut + SwordIn;
//				if (moveDir.magnitude > .1f) {
//					moveDir = Vector3.Normalize (moveDir);
//					moveDir.z = moveDir.z * .1f;
//				}
//				Sword.transform.localPosition += moveDir * Time.deltaTime * 5.0f;

				Sword.GetComponent<Transform> ().localPosition = SwordIn;
				IsSwordIn = true;
			}

			if (Sword.GetComponent<Transform> ().localPosition.z <= .01 || Sword.GetComponent<Transform> ().localPosition.z >= -.01) {
				IsAttacking = false;
			}
		}
	}


			

}
