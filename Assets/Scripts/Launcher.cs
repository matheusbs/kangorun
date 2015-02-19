using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour
{
    public GameObject itemPrefab;
    public GameObject stonePrefab;
    private Vector3 _pos;
    private bool _isPaused;

    // Use this for initialization
    void Start()
    {
        _isPaused = false;
        Launch();
    }

    void Launch()
    {
        if (_isPaused) return;

        if (Random.Range(0, 100) < 25)
        {
            GameObject stone = GameObject.Instantiate(stonePrefab) as GameObject;
            stone.transform.parent = transform;
        }
        else
        {
            GameObject item = GameObject.Instantiate(itemPrefab) as GameObject;
            item.transform.parent = transform;
            _pos = transform.position;
            _pos.y = Random.Range(-3.5f, 1.4f);
            item.transform.position = _pos;
        }

        Invoke("Launch", Random.Range(0.1f, 2.5f));
    }

    void PauseGame()
    {
        _isPaused = true;
    }
}
