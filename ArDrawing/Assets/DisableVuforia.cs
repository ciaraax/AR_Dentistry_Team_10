using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class DisableVuforia : MonoBehaviour {

	// Use this for initialization
	void Start () {
		VuforiaBehaviour.Instance.enabled = false;
		//MainCamera.Vuforia.VuofriaBehaviour.enable (false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OffVuforia()
	{
		VuforiaBehaviour.Instance.enabled = false;
	}
}
