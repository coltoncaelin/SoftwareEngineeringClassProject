using UnityEngine;
using System.Collections;

public class dont_destroy_on_load : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad (gameObject);
	}
}
