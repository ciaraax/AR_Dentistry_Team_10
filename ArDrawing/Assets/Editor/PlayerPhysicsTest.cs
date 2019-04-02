using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class PlayerPhysicsTest {

	[UnityTest] // testing that it moves the player on the x axis
	public IEnumerator PlayerMovesOnXAxisis() {
		var player = new GameObject().AddComponent<Player>();
		player.speed = 1;

		yield return null;

		Assert.AreEqual (1, player.transform.position.x, 25f); 
	}
}
