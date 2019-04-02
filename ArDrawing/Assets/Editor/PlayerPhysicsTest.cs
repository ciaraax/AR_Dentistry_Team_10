using UnityEngine;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayerPhysicsTest {

	[Test]
	public void PlayerPhysicsTestSimplePasses() {
		// Use the Assert class to test conditions.
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator PlayerPhysicsTestWithEnumeratorPasses() {
		var gobj = new GameObject ();
		gobj.AddComponent<Rigidbody2D> ();
		var originalPosition = gobj.transform.position.y;

		yield return new WaitForFixedUpdate ();

		Assert.AreNotEqual (originalPosition, gobj.transform.position.y);
	}
}
