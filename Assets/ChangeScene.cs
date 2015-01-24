using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour {

	public void changeScene( string sceneToChangeTo ){
		Application.LoadLevel (sceneToChangeTo);
	}


}