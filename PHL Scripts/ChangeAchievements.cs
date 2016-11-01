using UnityEngine;
using System.Collections;

public class ChangeAchievements : MonoBehaviour {

	void OnGUI()
	{
		if (GUI.Button (new Rect (10, 100, 100, 30), "Circles up")) 
		{
			AchievementsInformation.staticAchieveInfo.Save();
		}

		if (GUI.Button (new Rect (10, 140, 100, 30), "Squares up")) 
		{
			AchievementsInformation.staticAchieveInfo.Load ();
		}

		if (GUI.Button (new Rect (10, 180, 100, 30), "Circles down")) 
		{
			AchievementsInformation.staticAchieveInfo.circlesTapped -= 1;
		}

		if (GUI.Button (new Rect (10, 220, 100, 30), "Squares down")) 
		{
			AchievementsInformation.staticAchieveInfo.squaresTapped -= 1;
		}


	}

}
