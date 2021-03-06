﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneManagmentTest {



	public static IEnumerable<string> LevelTestCases{
		get { return new List<string> { "DuckDrawing", "HomeScreen", "MainLevel", "multiple_image"  }; }
	}

	[UnityTest]
	public IEnumerator LevelIsValid([ValueSource("LevelTestCases")] string levelName)
	{
		yield return LoadLevel (levelName);

		Assert.IsTrue (true);
	}

	[TearDown]
	public void UnloadLevel(){

		SceneManager.UnloadSceneAsync(sceneToUnload);
	}

	private string sceneToUnload;

	private IEnumerator LoadLevel(string levelName){

		sceneToUnload = levelName;

		var loadSceneOperation = SceneManager.LoadSceneAsync (levelName);
		loadSceneOperation.allowSceneActivation = true;

		while (!loadSceneOperation.isDone)
			yield return null;
	}
}
