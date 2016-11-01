using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressCircles : MonoBehaviour {

	public Image image;

	void Update () {
		
		image.fillAmount = (float)(AchievementsInformation.staticAchieveInfo.circlesTapped / 500.0);
	}

}
