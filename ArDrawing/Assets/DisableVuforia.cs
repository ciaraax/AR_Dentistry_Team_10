using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DisableVuforia : MonoBehaviour {

	// Use this for initialization
	void Start () {
		VuforiaBehaviour.Instance.enabled = false; // this will disable vuforia on load to make the 2d game playable

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OffVuforia()
	{
		VuforiaBehaviour.Instance.enabled = false;
	}
}
