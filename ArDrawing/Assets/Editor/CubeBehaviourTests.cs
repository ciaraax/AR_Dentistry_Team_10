using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class CubeBehaviourTests {

	private CubeBehaviourScript cubeBehaviour;

	[SetUp]
	public void SetUp() {

		cubeBehaviour = new CubeBehaviourScript ();
	}


	[Test]
	public void minAndMaxTest(){

		Assert.AreEqual (2, cubeBehaviour.mScaleMax);
		Assert.AreEqual (0.5, cubeBehaviour.mScaleMin);
	}

	[Test]
	public void cubeHealthTest(){

		Assert.AreEqual (100, cubeBehaviour.mCubeHealth);

	}

	[Test]
	public void growingSpeedTest(){

		Assert.AreEqual (10, cubeBehaviour.mGrowingSpeed);

	}

	[Test]
	public void maxSpeedTest(){

		Assert.AreEqual (30, cubeBehaviour.mOrbitMaxSpeed);

	}


}
