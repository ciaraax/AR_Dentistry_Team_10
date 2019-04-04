using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MobileMovement : MonoBehaviour {

	// here i add code to make the player respond to input from mobile tilting
	public void Update () {
		transform.Translate (Input.acceleration.x, 0, -Input.acceleration.z);
	}
}
