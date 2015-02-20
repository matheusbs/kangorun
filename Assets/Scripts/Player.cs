using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private const float _jumpForce = 9.8f;
    private Animator _animator;
    private bool _isJumping;
    private GameObject _manager;
	private int _tempo;
	private int _score;
	private float a;
	private int z;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
        _isJumping = false;
		_tempo = 30;
		_score = 0;
		a = 0;
		z = 0;
        Time.timeScale = 1f;
        _manager = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (_isJumping) return;

        if (Input.GetMouseButtonDown(0))
        {
            rigidbody2D.velocity = Vector2.up * _jumpForce;
            _animator.SetTrigger("Jump");
            _isJumping = true;
        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
		if (c.collider.CompareTag("Stone"))
        {
            collider2D.isTrigger = true;
            _animator.SetTrigger("Die");
            _manager.SendMessage("GameOver");
            Invoke("DieDude", 2f);
			Application.LoadLevel("MainMenu");
            return;
        }
        _animator.SetTrigger("Run");
        _isJumping = false;
    }

	
	void OnGUI(){
		a = Time.time;
		z = (int) a;
		z = Mathf.Abs(_tempo - z);
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
		_tempo += 5;
		_score += 10;
	}

    void DieDude()
    {
        Time.timeScale = 0f;
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D c)
    {
        if (c.CompareTag("Item"))
        {
            Destroy(c.gameObject);
        }
    }
}
