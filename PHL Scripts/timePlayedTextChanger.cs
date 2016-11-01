using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class timePlayedTextChanger : MonoBehaviour {

	public static Text theText;

	// Use this for initialization
	void Start () 
	{
		theText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () 
	{
		theText.text = ((int)(AchievementsInformation.staticAchieveInfo.timePlayed) / 60).ToString() + ":" + 
			((int)(AchievementsInformation.staticAchieveInfo.timePlayed) % 60).ToString("D2");
	}
}

