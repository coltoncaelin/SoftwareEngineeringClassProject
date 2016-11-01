using UnityEngine;
using System.Collections;

public class PlayerPreferencesScript : MonoBehaviour {

	public float gameVolume = 1.0f;
	public float SFXVolume = 1.0f;
	public static PlayerPreferencesScript instance = null;
	public static PlayerPreferencesScript Instance {
		get { return instance; }
	}
	void Awake() {
		if (instance != null && instance != this){
			Destroy (this.gameObject);
			return;
		}else{
			instance = this;
		}
		DontDestroyOnLoad (this.gameObject);
	}
		
}