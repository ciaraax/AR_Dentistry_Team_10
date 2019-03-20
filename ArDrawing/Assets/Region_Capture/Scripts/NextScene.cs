using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextScene : MonoBehaviour {

	public void changeNextScene (string scenename){

		Application.LoadLevel (scenename);
	}
}
