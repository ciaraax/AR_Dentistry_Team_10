using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class BasicTest {

	[Test]
	public void Basic()
	{

		bool isActive = false;

		Assert.AreEqual(false, isActive);

	}

	[Test]
	public void CatchingErrors()
	{

		GameObject gameObject = new GameObject("test");

		Assert.Throws<MissingComponentException>(
			() => gameObject.GetComponent<Rigidbody>().velocity = Vector3.one
		);

	}



}
