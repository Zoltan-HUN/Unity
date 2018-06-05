using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RespawnController : MonoBehaviour {

	public RespawnableObject[] respawnableObjects;


	void Start () {

	}


	void Update () {

	}


	public void resetGame()
	{
		foreach (RespawnableObject respawnableObject in respawnableObjects)
		{
			respawnableObject.respawn();
		}
	}
}
