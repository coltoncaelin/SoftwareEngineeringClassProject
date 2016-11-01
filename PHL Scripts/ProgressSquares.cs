using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressSquares : MonoBehaviour {

	public Image image;

	void Update () {
		image.fillAmount = (float)(AchievementsInformation.staticAchieveInfo.squaresTapped / 100.0);
	}

}
