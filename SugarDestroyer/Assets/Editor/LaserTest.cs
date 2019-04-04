using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class LaserTest {

	private LaserScript laser;

	[SetUp]
	public void SetUp() {

		laser = new LaserScript ();
	}

	[Test]
	public void fireRateTest(){	 

		Assert.AreEqual (.5, laser.mFireRate);

	}

	[Test]
	public void fireRangeTest(){	 

		Assert.AreEqual (50, laser.mFireRange);

	}

	[Test]
	public void hitForceTest(){	 

		Assert.AreEqual (100, laser.mHitForce);

	}

	[Test]
	public void laserDamageTest(){	 

		Assert.AreEqual (100, laser.mLaserDamage);

	}
}
