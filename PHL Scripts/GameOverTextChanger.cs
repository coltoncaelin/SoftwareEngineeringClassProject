using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverTextChanger : MonoBehaviour {

	private GameObject theTimerObject;
	TimeManager timeManagerScript;
	public static Text theText;
	private double endingtime = .001;

	// Use this for initialization
	void Start () {
		theText = GetComponent<Text>();
		theTimerObject = GameObject.Find ("Timer");
		timeManagerScript = theTimerObject.GetComponent<TimeManager>();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeManagerScript.startingTime <= endingtime) {
			float highScore = (timeManagerScript.startingTimePermanent + timeManagerScript.totalTimeAdded -
			                  timeManagerScript.totalTimeRemoved);
			theText.text = " Game Over: \nYou lasted " + highScore.ToString () + " seconds.";
			endingtime = -3000.0;
			if (highScore > AchievementsInformation.staticAchieveInfo.highScoreReached) 
			{
				AchievementsInformation.staticAchieveInfo.highScoreReached = highScore;
				AchievementsInformation.staticAchieveInfo.Save ();
			}

			//Advertisements.adIsReady = true;
		}
	}
}
