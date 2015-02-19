using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture2D background;
	public Texture2D jogar;
	public Texture2D opcoes;
	public Texture2D sair;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseUp(){
		Application.LoadLevel("Game");
	}

	/*void OnGUI() {
		// 733 440
				
		GUI.BeginGroup (new Rect(110, 150, 500, 250));

		if (GUI.Button (new Rect (160, 43, 170, 50), jogar)) {
			Application.LoadLevel("Game");
		}
		if (GUI.Button (new Rect (145, 115, 200, 55), opcoes)) {
			Application.LoadLevel("Opcoes");
		}
		if (GUI.Button (new Rect (177, 190, 135, 50), sair)) {
			Application.Quit();
		}
		GUI.EndGroup();
	}*/
}
