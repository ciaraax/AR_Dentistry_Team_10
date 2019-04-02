using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayerPhysicsTest {
	private Player player;
	[SetUp]
	public void SetUp() {

		player = new Player ();
	}

	[Test]
	public void playableMapSize() {
		// To ensure that the player is within a certain map range and cant got outofbounds
		Assert.AreEqual(5, player.mapWidth);
	}

	[Test]
	public void speedOfPlayer() {
		// To ensure that the player has a consistant speed
		Assert.AreEqual(15, player.speed);
	}

	[UnityTest]
	//This is a test to prove that the player can move on the X axis and at a constant speed
	public IEnumerator PlayerMovesOnXAxisis() {
		var player = new GameObject().AddComponent<Player>();
		player.speed = 1;

		yield return null;

		Assert.AreEqual (1, player.transform.position.x, 1f); 
	}
	[UnityTest] 
	public IEnumerator RigidBody_WillBeAffectedByPhysics(){
		var player = new GameObject();
		player.AddComponent<Rigidbody>();
		var originalPosition = player.transform.position.y;

		yield return new WaitForFixedUpdate();

		Assert.AreNotEqual (originalPosition, player.transform.position.y);
	}

}
