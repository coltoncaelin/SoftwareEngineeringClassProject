using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgressGametime : MonoBehaviour {

	private GameObject theTimerObject;
	TimeManager timeManagerScript;
	public Image image;

	void Start () {
		theTimerObject = GameObject.Find ("Timer");
		timeManagerScript = theTimerObject.GetComponent<TimeManager>();
	}
		
	void Update () {
		image.fillAmount = (float)(timeManagerScript.startingTime / 70.0);
	}

}
