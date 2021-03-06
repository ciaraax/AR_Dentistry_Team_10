﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class BasicTest {

	[SetUp]
	public void ResetScene()
	{

		EditorSceneManager.NewScene(NewSceneSetup.EmptyScene);

	}
		

	[Test]
	public void BasicTestOne()
	{

		bool isActive = false;

		Assert.AreEqual(false, isActive);

	}

	[Test]
	public void CatchingErrors()
	{

		GameObject gameObject = new GameObject ("test");

		Assert.Throws<MissingComponentException> (
			() => gameObject.GetComponent<Rigidbody> ().velocity = Vector3.one
		);

	}
		
}
