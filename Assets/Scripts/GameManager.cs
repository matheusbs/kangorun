using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
    private bool _isRunning;

    void Start()
    {
        _isRunning = true;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isRunning = !_isRunning;

            if (_isRunning)
            {
                Time.timeScale = 1f;
            }
            else
                Time.timeScale = 0f;
        }
    }


    void GameOver()
    {
        BroadcastMessage("PauseGame");    
    }

/*	void OnGUI(){
		if (Time.timeScale == 1f) {
			a = Time.time;
			z = (int)a;
			z = Mathf.Abs (_tempo - z);
		}
		
		GUI.TextArea (new Rect (90, 45, 50, 30), "  "+ z);
		
		if(z == 0){
			_animator.SetTrigger("Die");
			_manager.SendMessage("GameOver");
			Invoke("DieDude", 2f);
			Application.LoadLevel("MainMenu");
			return;
		}
		
		GUI.TextArea (new Rect (155, 10, 50, 30), "  "+ _score);
	}
	
	void PlayerScored(){
		_score += 10;
	}*/
}
