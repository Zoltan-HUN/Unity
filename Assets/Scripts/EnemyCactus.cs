using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyCactus : MonoBehaviour {
	public float health = 100;
	private GameObject player;
	public float m_jumpForce;
	private Rigidbody2D cactus;
	public float distance;
	public Transform bDollar;
	public static int killed;

	public GameObject healthb;



	// Use this for initialization
	void Start () {
		this.cactus = gameObject.GetComponent<Rigidbody2D>();
		bDollar.gameObject.SetActive (false);
		killed = PlayerPrefs.GetInt ("killed", killed);

	}

	// Update is called once per frame
	void Update () {
		Vector3 player = GameObject.FindWithTag ("Player").transform.position;
		Vector3 cact = GameObject.FindWithTag ("Cactus").transform.position;
		//distance = GameObject.FindWithTag ("Player").transform.position.x = GameObject.FindWithTag ("Cactus").transform.position.x ;
		distance = cact.x - player.x;

	if (distance <= 10) {

			if (Input.GetButtonDown ("Jump")) {
				if (cactus.velocity.y == 0) {
					cactus.velocity = new Vector2 (0, m_jumpForce);
				}

				}
			if (Input.GetButtonDown ("Fire1")) {
				if (cactus.velocity.y == 0) {
					cactus.velocity = new Vector2 (0, m_jumpForce);
				}
			}
	}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("OnCollisionEnter2D called.");
		if (coll.gameObject.tag == "Laser") {

		health -= LaserController.damage;
		
			healthb.gameObject.transform.localScale -= new Vector3 (0.1f, 0, 0);
			healthb.gameObject.transform.position -= new Vector3 (0.2f, 0, 0);
			coll.gameObject.SetActive(false);

			if (this.health == 0) {
				//AudioManager.instance.PlaySound ("DeathVoice");
				killed = 10;
				PlayerPrefs.SetInt ("killed", killed);
				Destroy (this.gameObject);
				bDollar.gameObject.SetActive (true);

				//PlayerPrefs.SetString ("killed", killed);

			}


		}
		/*AudioSource src = GetComponent < AudioSource > ();
		if (src != null) {
			
			src.Play ();
		}*/
	}
}