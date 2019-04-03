using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb : MonoBehaviour, IVirtualButtonEventHandler{

	public GameObject vbBtnObj;
	public Animator teethAnimation;


	void Start () {

		vbBtnObj = GameObject.Find("VirtualButton");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
		teethAnimation.GetComponent<Animator> ();

	}

	public void OnButtonPressed(VirtualButtonBehaviour vb) 
	{
		teethAnimation.Play("teeth_animation");
		Debug.Log ("Button Pressed");

	}

	public void OnButtonReleased(VirtualButtonBehaviour vb) 
	{
		teethAnimation.Play("none");
		Debug.Log ("Button Released");

	}

}