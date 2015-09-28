using UnityEngine;
using System.Collections;

public class PointerScript : MonoBehaviour {

	public Transform player;

	public GameObject pointer;
	// Use this for initialization
	void Start () {
		pointer.SetActive (false);

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.LookAt (player);

		if (player.gameObject.GetComponent<BeeControls> ().distance > 10) {

			pointer.SetActive(true);

		}
		else{
			pointer.SetActive(false);
		}

	}
}
