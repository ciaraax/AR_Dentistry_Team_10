using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class SpawnScriptTest {

	private SpawnScript spawn;

	[SetUp]
	public void SetUp() {

		spawn = new SpawnScript ();
	}

	[Test]
	public void howManyCubes(){	 

		Assert.AreEqual (30, spawn.mTotalCubes);

	}

	[Test]
	public void timeToSpawn(){	 

		Assert.AreEqual (1, spawn.mTimeToSpawn);

	}
		
}
