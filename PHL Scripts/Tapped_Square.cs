using UnityEngine;
using System.Collections;

public class Tapped_Square : MonoBehaviour {

	private GameObject theTimerObject;
	TimeManager timeManagerScript;
	float tappedTimer = 0.0f;

	void Start () {
		theTimerObject = GameObject.Find ("Timer");
		timeManagerScript = theTimerObject.GetComponent<TimeManager>();
	}
		
	void Update () {
		if(Input.GetMouseButton(0))
		{
			tappedTimer += Time.deltaTime;
		}
		if (tappedTimer >= 1.25f) 
		{
			timeManagerScript.startingTime += 5.0f;
			timeManagerScript.totalTimeAdded += 5.0f;
			AchievementsInformation.staticAchieveInfo.squaresTapped += 1;
			AchievementsInformation.staticAchieveInfo.Save ();

			Destroy (gameObject);
		}
	}
}