using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;

public class ColouringTest {

	private RegionCapture rc;
	private RenderTextureCamera rtc;

	[SetUp]
	public void SetUp() {

		rc = new RegionCapture ();
		rtc = new RenderTextureCamera ();

	}

	[Test]
	public void ColouringTestSimplePasses() {

		Assert.IsFalse(rc.FlipX);
		Assert.IsFalse(rc.FlipY);
	}

	[Test]
	public void textureResolution() {

		Assert.AreEqual(512, rtc.TextureResolution);


	}


}
