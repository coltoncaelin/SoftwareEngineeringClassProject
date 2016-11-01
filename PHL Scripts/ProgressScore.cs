using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressScore : MonoBehaviour {

	public Image image;

	void Update () {
		image.fillAmount = (float)(AchievementsInformation.staticAchieveInfo.highScoreReached / 90.0);
	}

}
