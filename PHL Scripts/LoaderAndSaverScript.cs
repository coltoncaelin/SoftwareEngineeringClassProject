using UnityEngine;
using System.Collections;

public class LoaderAndSaverScript : MonoBehaviour {

	public static LoaderAndSaverScript staticLoader;
	void Awake () {
		if (staticLoader == null) {
			DontDestroyOnLoad (gameObject);
			staticLoader = this;
		} else if (staticLoader != this)
			Destroy (gameObject);
	}
		//if(AchievementsInformation.staticAchieveInfo.circlesTapped)
		

		
	// Update is called once per frame
	void Update () {
		AchievementsInformation.staticAchieveInfo.Load ();
		AchievementsInformation.staticAchieveInfo.timePlayed  += Time.deltaTime;
		AchievementsInformation.staticAchieveInfo.Save ();
	}
}
