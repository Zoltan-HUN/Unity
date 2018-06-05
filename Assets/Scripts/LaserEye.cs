using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LaserEye : MonoBehaviour {

	public GameObject laser; 
	public float speed = 1f; 
	public Transform firePoint;

	public List<GameObject> laserPool = new List<GameObject>();
	public int laserPoolSize;
	public static int shoots=0;


	void Start () {
		for (int i = 0; i < laserPoolSize; i++)
		{
			GameObject newLaser = Instantiate(laser, firePoint.position, laser.transform.rotation) as GameObject;
			newLaser.SetActive(false);
			laserPool.Add(newLaser);
		}
		shoots = PlayerPrefs.GetInt ("shoots", shoots);
	}


	void Update () {	
		if (Input.GetButtonDown ("Fire1")) {
			fireLaser();
			AudioSource shoot_laser = GetComponent<AudioSource> ();
			shoot_laser.Play ();
			shoots += 1;
			PlayerPrefs.SetInt ("shoots", shoots);


		}
	}

	private void fireLaser() {
		float newRotationAngle = Movement.facingRight ? 90 : 270;
	

		foreach (GameObject laserClone in laserPool)
		{
			if (!laserClone.activeSelf)
			{
				laserClone.SetActive(true);
				Vector3 force = Movement.facingRight ? transform.right : transform.right * -1;
				laserClone.GetComponent<Rigidbody2D>().velocity = force * speed;
				break;
			}
		}
	}
}
