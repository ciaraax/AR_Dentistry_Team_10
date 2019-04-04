using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MobileMovement : MonoBehaviour {

	// Update is called once per frame
	public void Update () {
		transform.Translate (Input.acceleration.x, 0, -Input.acceleration.z);
	}
}
