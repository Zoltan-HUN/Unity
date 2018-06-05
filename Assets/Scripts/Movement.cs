using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

	private Rigidbody2D m_rb;
	private Animator m_animator;
	public static bool facingRight = true;

	public float m_jumpForce = 3f;
	public float m_speed = 4f;

	public Transform fallDeathCheck;
	private RespawnController respawnController;

	private GameObject gameManager;

	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	bool grounded = false;

	public float timeSpentIdle = 0f;
	private string idleAnimation;


	void Start()
	{
		this.m_rb = gameObject.GetComponent<Rigidbody2D>();
		gameManager = GameObject.FindGameObjectWithTag("GameManager");
		respawnController = gameManager.GetComponent<RespawnController>();
		m_animator = GetComponent<Animator>();
		facingRight = true;
	}


	void FixedUpdate()
	{
	if (gameObject.transform.position.y <= fallDeathCheck.position.y)
		{
			respawnController.resetGame();
		}
	if (Input.GetButtonDown("Jump") && m_rb.velocity.y == 0)
		{
			
			m_rb.velocity = new Vector2 (0, m_jumpForce);
			AudioSource hop = GetComponent<AudioSource> ();
			hop.Play ();

				}

		float movement = Input.GetAxis("Horizontal");
		this.m_rb.velocity = new Vector2 (movement * m_speed, m_rb.velocity.y);
	
		if (facingRight && movement < 0)
		{
			flip();
		}
		else if (!facingRight && movement > 0)
		{
			flip();
		}
		m_animator.SetFloat("Speed", Mathf.Abs(m_rb.velocity.x));

		bool wasKeyPressed = false;
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		m_animator.SetBool("Ground", grounded);



		timeSpentIdle += Time.deltaTime;
		/*
		if (timeSpentIdle >= IDLE_ANIM_COOLDOWN)
		{
			playRandomIdleAnimation();
		}

		if (timeSpentIdle > IDLE_ANIM_COOLDOWN || (Mathf.Abs(m_rb.velocity.x) > 0.1) || (!grounded))
		{
			timeSpentIdle = 0f;
		}
*/

	}

	private void flip()
	{
		facingRight = !facingRight;
		Vector3 oldScale = this.GetComponent<Transform>().localScale;

		oldScale.x *= -1.0f;

		this.GetComponent<Transform>().localScale = oldScale;


	}
void playRandomIdleAnimation()
	{
		int animationPostfix = Random.Range(0, 100) > 50 ? 2 : 1;

	
		idleAnimation = "Relax";
		Debug.Log("Playing animation: " + idleAnimation);
		m_animator.SetTrigger(idleAnimation);

}


	void OnTriggerEnter2D(Collider2D coll) {
			Debug.Log ("OnCollisionEnter2D called.");
		if (coll.gameObject.tag == "money") {

			//Destroy (gameObject.FindWithTag("money"));
			coll.gameObject.SetActive (false);

			ScoreScript.scoreValue += 1;
		}
		if (coll.gameObject.tag == "5money"){

				//Destroy (gameObject.FindWithTag("money"));
				coll.gameObject.SetActive (false);

				ScoreScript.scoreValue += 5;
		}
		if (coll.gameObject.tag == "heart") {
			coll.gameObject.SetActive (false);
			GameController.health += 1;


		}

	}

	

}