
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement ;

public class menu : MonoBehaviour {

	public void president(){
		SceneManager.LoadScene ("PresidenteEscena");
	}

	public void exit(){
		Application.Quit ();
	}
}