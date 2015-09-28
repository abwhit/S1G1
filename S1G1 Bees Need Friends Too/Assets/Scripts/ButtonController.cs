using UnityEngine;
using System.Collections;

public class ButtonController : MonoBehaviour {


	public void OnClickRestart()
	{
		Application.LoadLevel ("GameScene");
	}

	public void OnClickMenu()
	{
		Application.LoadLevel ("Menu");

	}

	public void OnClickQuit()
	{
		// How to quit the game in the editor 
		#if UNITY_EDITOR
		
		UnityEditor.EditorApplication.isPlaying = false;
		
		#else
		
		
		Application.Quit ();
		
		#endif


	}

}
