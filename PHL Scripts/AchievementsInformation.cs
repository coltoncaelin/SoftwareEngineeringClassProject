using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class AchievementsInformation : MonoBehaviour {

	public static AchievementsInformation staticAchieveInfo;

	public int circlesTapped;
	public int squaresTapped;
	public float timePlayed;
	public float highScoreReached;

	// Use this for initialization
	void Awake () {
		if (staticAchieveInfo == null) {
			DontDestroyOnLoad (gameObject);
			staticAchieveInfo = this;
		} else if (staticAchieveInfo != this)
			Destroy (gameObject);
	}
	
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/AchievementInfo.dat");
		AchievementData data = new AchievementData ();
		data.circlesTapped = circlesTapped;
		data.squaresTapped = squaresTapped;
		data.highScoreReached = highScoreReached;
		data.timePlayed = timePlayed;

		bf.Serialize (file, data);
		file.Close ();
	}

	public void Load()
	{
		if (File.Exists (Application.persistentDataPath + "/AchievementInfo.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/AchievementInfo.dat", FileMode.Open);
			AchievementData data = (AchievementData)bf.Deserialize (file);
			file.Close ();

			circlesTapped = data.circlesTapped;
			squaresTapped = data.squaresTapped;
			timePlayed = data.timePlayed;
			highScoreReached = data.highScoreReached;
		}
	}

	public void ClearData()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/AchievementInfo.dat");
		AchievementData data = new AchievementData ();
		data.circlesTapped = 0;
		data.squaresTapped = 0;
		data.highScoreReached = 0.0f;
		data.timePlayed = 0.0f;

		bf.Serialize (file, data);
		file.Close ();
	}
}


[Serializable]
class AchievementData
{
	public int circlesTapped;
	public int squaresTapped;
	public float timePlayed;
	public float highScoreReached;
}