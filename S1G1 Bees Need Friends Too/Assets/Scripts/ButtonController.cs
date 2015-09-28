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

}
