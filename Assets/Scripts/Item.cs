using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
    public float speed;
    private bool _isPaused;

    void Start()
    {
        _isPaused = false;
    }

    void FixedUpdate()
    {
        if (_isPaused) return;

        transform.Translate(Vector3.left * speed);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Wall"))
            Destroy(gameObject);
    }

    void PauseGame()
    {
        _isPaused = true;
    }
}
