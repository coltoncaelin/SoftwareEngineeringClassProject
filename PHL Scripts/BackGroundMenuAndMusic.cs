using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// This Class controls the Back Ground Music, whether or not its Muted, And Saves that state in playerPrefs.
/// </summary>
public class BackGroundMenuAndMusic : MonoBehaviour
{
    public static BackGroundMenuAndMusic BGMusic;       //StatocReference setup - this object will persist from Scene1->Forward.(DoNotDestroyOnLoad)

    // Use this for initialization
    void Start ()
	{
		//Setup a Singleton Like Object
		if (BGMusic == null) {
			DontDestroyOnLoad (gameObject);
			BGMusic = this;
		}
        //and make sure it persists
        //if another is found.. destroy so only one exists.
        else if (BGMusic != this) {
			Destroy (gameObject);
		}
	}
}