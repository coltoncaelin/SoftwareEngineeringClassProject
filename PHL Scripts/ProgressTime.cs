using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressTime : MonoBehaviour {

	public Image image;
	// Update is called once per frame
	void Update () {
		image.fillAmount = (float)(AchievementsInformation.staticAchieveInfo.timePlayed / 3600.0);
	}
		
}
