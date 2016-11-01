using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Update is called once per frame
	public void changeToScene (int sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo);
	}

	public void changeToSceneString (string sceneToChangeTo) {
		SceneManager.LoadScene(sceneToChangeTo);
	}
}
