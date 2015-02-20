using UnityEngine;
using System.Collections;

public class PlayerButton : MonoBehaviour {
	
	void Start () {
	
	}

	void Update () {
	
	}

	void OnMouseDown() {
		Application.LoadLevel("Game");
	}
}
