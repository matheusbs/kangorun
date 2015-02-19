using UnityEngine;
using System.Collections;

public class TextureController : MonoBehaviour
{
    public float scrollVelocity;
    private float _offSet;
    private bool _isPaused;

    // Use this for initialization
    void Start()
    {
        _offSet = 0;
        renderer.material.mainTextureOffset = Vector2.zero;
        _isPaused = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (_isPaused) return;

        _offSet += scrollVelocity;

        if (_offSet > 1f)
            _offSet -= 1f;

        renderer.material.mainTextureOffset = Vector2.right * _offSet;
    }

    void PauseGame()
    {
        _isPaused = true;
    }
}
