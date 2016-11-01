using UnityEngine;
using System.Collections;

public class TutorialCircle : MonoBehaviour {

	float timer = 0.0f;
	bool disappeared = false;

	void Update(){
		if (disappeared)
			timer += Time.deltaTime;
		if (timer >= 3.0f) {
			disappeared = false;
			timer = 0.0f;
			gameObject.transform.localScale = new Vector3 (1.0f, 1.0f, 1.0f);

		}
	}

	void OnMouseDown() 
	{
		AchievementsInformation.staticAchieveInfo.circlesTapped += 1;
		AchievementsInformation.staticAchieveInfo.Save ();

		gameObject.transform.localScale = new Vector3(0.0f, 0.0f, 0.0f);
		disappeared = true;
	}
}