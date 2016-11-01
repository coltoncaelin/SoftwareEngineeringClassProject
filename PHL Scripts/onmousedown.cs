using UnityEngine;
using System.Collections;

public class onmousedown : MonoBehaviour {

	void onMouseDown(){
		AchievementsInformation.staticAchieveInfo.ClearData ();
	}
}
