using UnityEngine;
using System.Collections;

public class TutorialSquare : MonoBehaviour {

	float tappedTimer = 0.0f;
	float disappearedTimer = 0.0f;
	bool disappeared = false;

	void Update(){
		if(Input.GetMouseButton(0))
		{
			tappedTimer += Time.deltaTime;
		}

		if (tappedTimer >= 1.25f) {
			gameObject.transform.localScale = new Vector3 (0.0f, 0.0f, 0.0f);
			disappeared = true;
		}

		if (disappeared)
			disappearedTimer += Time.deltaTime;

		if (disappearedTimer >= 3.0f) {
			disappeared = false;
			disappearedTimer = 0.0f;
			tappedTimer = 0.0f;
			gameObject.transform.localScale = new Vector3 (.65f, .65f, 1.0f);

		}
	}
		
}