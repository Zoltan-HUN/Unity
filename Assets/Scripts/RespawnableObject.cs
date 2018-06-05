using UnityEngine;
using System.Collections;

public class RespawnableObject : MonoBehaviour {

	public Transform respawnPoint;

	public void respawn()
	{
		gameObject.transform.position = respawnPoint.position;
		GameController.health -= 1;


	}
	void OnCollisionEnter2D(Collision2D coll){
	if (coll.gameObject.tag == "Cactus") {

		    gameObject.transform.position = respawnPoint.position;
			GameController.health -= 1;

	}
}
}