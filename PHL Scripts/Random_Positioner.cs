
using UnityEngine;
using System.Collections;

public class Random_Positioner : MonoBehaviour {
	public GameObject go;
	public GameObject theObject;
	public float maxPosX = 8.5f;
	public float minPosX = -8.5f;
	public float maxPosY = 11.0f;
	public float minPosY = -14.0f;
	public int max = 5;

	private GameObject theTimerObject;
	TimeManager timeManagerScript;

	void Start()
	{
		theTimerObject = GameObject.Find ("Timer");
		timeManagerScript = theTimerObject.GetComponent<TimeManager>();
		StartCoroutine(spawn());
	}
		

	void createObjects()
	{
		var theNewPos = new Vector3 (Random.Range (minPosX, maxPosX), Random.Range (minPosY, maxPosY), 0);
		GameObject go = Instantiate (theObject);
		go.transform.position = theNewPos;
	}

	IEnumerator spawn() {
		float creationFactor = 1.0f;
		while(timeManagerScript.startingTime >= .01f)
		{
			for (int i = 0; i < 5; i++)
			{
					createObjects ();
					yield return new WaitForSeconds(3.0f / creationFactor);
			}
			creationFactor = creationFactor + .75f;
		}

	}
}