﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D (Collider2D col){
		GameController.health += 1;
	}
}