using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour
{
    public float speed;
    private Animator _animator;
    private bool _isPaused;

    // Use this for initialization
    void Start()
    {
        _isPaused = false;
        //_animator = GetComponent<Animator>();

        /*switch (Random.Range(0, 5))
        {
            case 1:
                _animator.SetTrigger("Stone1");
                break;
            case 2:
                _animator.SetTrigger("Stone2");
                break;
            default:
                _animator.SetTrigger("Stone0");
                break;
        }*/
    }

    // Update is called once per frame
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
