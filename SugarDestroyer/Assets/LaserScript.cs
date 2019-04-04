using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {

	public float mFireRate 	= .5f;
	public float mFireRange = 50f;
	public float mHitForce 	= 100f;
	public int mLaserDamage = 100;


	// Line render that will represent the Laser
	private LineRenderer mLaserLine;

	// Define if laser line is showing
	private bool mLaserLineEnabled;

	// Time that the Laser lines shows on screen
	private WaitForSeconds mLaserDuration = new WaitForSeconds(0.05f);

	private float mNextFire;

	// Use this for initialization
	void Start () {
		// getting the Line Renderer
		mLaserLine = GetComponent<LineRenderer>();

	}
	
	// Update is called once per frame
	void Update () {

		if ( Input.GetButton("Fire1") && Time.time > mNextFire ){
			Fire();
		}
	}

	// Shot the Laser
	private void Fire(){
		// Get ARCamera Transform
		Transform cam = Camera.main.transform;

		// DEfine the time of the next fire
		mNextFire = Time.time + mFireRate;

		// Set the origin of the RayCast
		Vector3 rayOrigin = cam.position;

		// Show the Laser using a Coroutine
		StartCoroutine(LaserFx());

		// Holdes the Hit information
		RaycastHit hit;

		// Set the oorigin position of the Laser Line
		// It will always 10 units down from the ARCamera
		// We adopted this logic for simplicity
		mLaserLine.SetPosition(0, transform.up * -10f );

		// Checks if the RayCast hit something
		if ( Physics.Raycast( rayOrigin, cam.forward, out hit, mFireRange )){

			// Set the end of the Laser Line to the object hitted
			mLaserLine.SetPosition(1, hit.point );

			CubeBehaviourScript cubeCtr = hit.collider.GetComponent<CubeBehaviourScript>();
			if ( cubeCtr != null ) {
				if ( hit.rigidbody != null ) {
					hit.rigidbody.AddForce(-hit.normal*mHitForce);
					cubeCtr.Hit( mLaserDamage );
				}
			}

		} else {
			// Set the enfo of the laser line to be forward the camera
			// using the Laser range
			mLaserLine.SetPosition(1, cam.forward * mFireRange );
		}
	}

	// Show the Laser Effects
	private IEnumerator LaserFx(){
		mLaserLine.enabled = true;


		// Way for a specific time to remove the LineRenderer
		yield return mLaserDuration;
		mLaserLine.enabled = false;
	}
}
