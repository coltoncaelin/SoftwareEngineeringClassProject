using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeVolume : MonoBehaviour {

	private GameObject theAudioObject;
	private Slider theSlider;

	private GameObject thePlayerPreferencesObject;
	private PlayerPreferencesScript thePlayerPreferencesScript;


	// Use this for initialization
	void Start () {
		theAudioObject = GameObject.Find ("AudioHoldingObject");
		theSlider = Slider.FindObjectOfType<Slider> ();

		thePlayerPreferencesObject = GameObject.Find ("PlayerPreferences");
		thePlayerPreferencesScript = thePlayerPreferencesObject.GetComponent<PlayerPreferencesScript>();

		theSlider.value = thePlayerPreferencesScript.gameVolume;
	}
	
	// Update is called once per frame
	void Update () {
		theAudioObject.GetComponent<AudioSource> ().volume = theSlider.value;
		thePlayerPreferencesScript.gameVolume = theSlider.value;
	}
}
