using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {
	public GameObject startMusic;

	public void Start(){
				startMusic = GameObject.Find ("BackgroundMusic");
				DontDestroyOnLoad (startMusic);
				
		}
	public void changeScene( int sceneToChangeTo ){
		if (sceneToChangeTo == 2) {
			startMusic.audio.Stop();
				}
		Application.LoadLevel (sceneToChangeTo);
	}


}