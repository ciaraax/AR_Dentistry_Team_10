using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	
		
	}
	
	// Update is called once per frame
	void Update () {

		int nbTouches = Input.touchCount;

		if (nbTouches > 0) {
			print (" Hey! That tickled");
		}
	}
}
