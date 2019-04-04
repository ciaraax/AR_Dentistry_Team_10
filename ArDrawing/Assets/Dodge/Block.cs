using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public void Start ()
	{
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;
	}

	// Update is called once per frame
	public void Update () {
		if (transform.position.y < -2f)
		{
			Destroy(gameObject);
		}
	}

}
