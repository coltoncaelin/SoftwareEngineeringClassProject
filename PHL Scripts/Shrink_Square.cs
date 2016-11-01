using UnityEngine;
using System.Collections;

public class Shrink_Square : MonoBehaviour
{
	private bool shrinking;
	public float targetScale = 0.25f;
	public float shrinkSpeed = 0.03f;

	private GameObject theTimerObject;
	TimeManager timeManagerScript;

	public GameObject shape; 


	// Use this for initialization
	void Start()
	{
		theTimerObject = GameObject.Find ("Timer");
		timeManagerScript = theTimerObject.GetComponent<TimeManager>();
		shrinking = true;
	}

	// Update is called once per frame
	void Update()
	{

		if (shrinking)
		{
			shape.transform.localScale -= Vector3.one * Time.deltaTime * shrinkSpeed;
			if (shape.transform.localScale.x < targetScale)
			{
				shrinking = false;
				timeManagerScript.startingTime -= 5.0f;
				timeManagerScript.totalTimeRemoved += 5.0f;
				Destroy(gameObject);
			}

			//transform.localScale -= (new Vector3(0.01F, 0.01F, 0.01f));
		}

	}
}
