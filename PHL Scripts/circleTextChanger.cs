using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class circleTextChanger : MonoBehaviour {

	public static Text theText;

	// Use this for initialization
	void Start () 
	{
		theText = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () 
	{
		theText.text = AchievementsInformation.staticAchieveInfo.circlesTapped.ToString ();	
	}
}

