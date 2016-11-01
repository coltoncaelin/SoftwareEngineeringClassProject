using UnityEngine;
using System.Collections;

public class Tapped_Shape : MonoBehaviour {
	private GameObject theTimerObject;
	TimeManager timeManagerScript;

	//public GameObject timeAddedUI;   To be used when UI text box displaying time added is ready

	void Start () {
		theTimerObject = GameObject.Find ("Timer");
		timeManagerScript = theTimerObject.GetComponent<TimeManager>();
	}

	void OnMouseDown() 
	{
		timeManagerScript.startingTime += 2.0f;
		timeManagerScript.totalTimeAdded += 2.0f;
		AchievementsInformation.staticAchieveInfo.circlesTapped += 1;
		AchievementsInformation.staticAchieveInfo.Save ();

		Destroy (gameObject);
	}
}