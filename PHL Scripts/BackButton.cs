using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour {

	public void changeToScene (int sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo);
	}

	void Update(){
		if (Input.GetKey (KeyCode.Escape))
			changeToScene (0);
}
}