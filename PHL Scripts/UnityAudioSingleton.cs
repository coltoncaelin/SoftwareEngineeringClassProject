using UnityEngine;
using System.Collections;

public class UnityAudioSingleton : MonoBehaviour {
	
	private static UnityAudioSingleton instance = null;
	public static UnityAudioSingleton Instance {
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