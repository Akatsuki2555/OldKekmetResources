using UnityEngine;
using UnityEditor;
using System.Collections;
using System.IO;

public class Build {

	[MenuItem("Building/Build Asset Bundles")]
	public static void BuildAssetBundles()
	{
		var path = Path.Combine(Application.dataPath, "Building/AssetBundles");
		if (!Directory.Exists(path))
		{
			Directory.CreateDirectory(path);
		}
		BuildPipeline.BuildAssetBundles(path);
	}
}
