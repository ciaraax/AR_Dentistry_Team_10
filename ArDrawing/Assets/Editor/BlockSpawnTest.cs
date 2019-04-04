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
	// ensuring the blocks are being spawned after one second
	[Test]
	public void TimeBetweenEachWave() {
		// Use the Assert class to test conditions.
		Assert.AreEqual(1	, spawn.timeBetweenWaves);
	}
	// ensuring the amount of blocked spawned is 4
	[Test]
	public void AmountOfBlockedSpawned() {
		Assert.AreEqual (4, spawn.amountToSpawn);
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode

}
