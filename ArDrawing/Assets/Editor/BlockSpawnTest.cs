using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BlockSpawnTest {
	
	private BlockSpawner spawn;

	[SetUp]
	public void SetUp() {

		spawn = new BlockSpawner ();
	}
	[Test]
	public void TimeBetweenEachWave() {
		// Use the Assert class to test conditions.
		Assert.AreEqual(1f, spawn.timeBetweenWaves);
	}

	[Test]
	public void TimeToSpawn() {
		// Use the Assert class to test conditions.		Assert.AreEqual(2f, spawn.Update);
	}


	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator BlockSpwanTestWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}
}
