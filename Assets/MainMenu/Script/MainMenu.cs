using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	void OnTriggerEnter2D(Collider2D c)
	{
		if (c.CompareTag("Sair"))
			Application.Quit();
	}
}
