/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunRotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 0, 1);

	}
} */
using UnityEngine;
using System.Collections;

public class SunRotation : MonoBehaviour
{
	public float speed = 10f;


	void Update ()
	{
		transform.Rotate(Vector3.back, speed * Time.deltaTime);
	}
}