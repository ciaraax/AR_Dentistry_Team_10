using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class SceneManagmentTest {

	[Test]
	public void SceneManagmentSimplePasses() {
		// Use the Assert class to test conditions.
	}

	// A UnityTest behaves like a coroutine in PlayMode
	// and allows you to yield null to skip a frame in EditMode
	[UnityTest]
	public IEnumerator SceneManagmentWithEnumeratorPasses() {
		// Use the Assert class to test conditions.
		// yield to skip a frame
		yield return null;
	}

	public static IEnumerable<string> LevelTestCases{
		get { return new List<string> { "DuckDrawing", "HomeScreen", "FindTheAnimalScene", "DrawingTwo"  }; }
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
