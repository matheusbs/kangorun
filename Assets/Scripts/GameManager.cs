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
}
