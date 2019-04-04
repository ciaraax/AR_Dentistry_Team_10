using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public void Start ()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
	}

	// Here we ensure that the block are not infinetly stacked up in the background
	// which will make the game lag
	public void Update () {
		if (transform.position.y < -2f)
		{
			Destroy(gameObject);
		}
	}

}
