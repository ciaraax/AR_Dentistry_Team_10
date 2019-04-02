using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 25f;
	public float mapWidth = 5f;
	private Rigidbody2D rb;
	void Start ()
	{
		rb = GetComponent<Rigidbody2D> ();
	}
	void FixedUpdate () {
		float x = Input.GetAxis ("Horizontal") * Time.fixedDeltaTime; // we get the input from the horizontal axis and * it by our fixed time of the last input
		Vector2 newPosition = rb.position + Vector2.right * x;
		newPosition.x = Mathf.Clamp(newPosition.x, - mapWidth, mapWidth); // this will restrict movement so it cant go out of the map
		rb.MovePosition(newPosition); // we want to get our current position and add vector to it so it moves logically

	}

	void OnCollisionEnter2D ()
	{
		FindObjectOfType<GameManager>().EndGame(); // when the blocks collide end the game
	}

}