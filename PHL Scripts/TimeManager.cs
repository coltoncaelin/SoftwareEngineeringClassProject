using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour {

    public float startingTime;
	public float startingTimePermanent;
	public float totalTimeAdded = 0.0f;
	public float totalTimeRemoved = 0.0f;
    public static Text theText;
    public GameObject gameOverScreen;
	public GameObject gameplayStuff;


    void Start () {
		
        theText = GetComponent<Text>();
		startingTimePermanent = startingTime;
			
	}

	void Update () {
        if (startingTime <= 0.001)
        {
			theText.text = "0";
			gameOverScreen.SetActive(true);
			gameplayStuff.SetActive (false);
            return;
        }
			
        startingTime -= Time.deltaTime; 
        theText.text = "" + System.Math.Round(startingTime, 0);
	}
}
