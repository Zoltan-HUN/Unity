using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {

	private Transform firePoint;

	public bool m_hasMaxTime = true;
	public float m_maxTime = 2.0f;
	public static float damage = 10;

	private float m_timeTravelled = 0.0f;

	//IDŐALPÚ
	void Awake()
	{
		firePoint = GameObject.FindGameObjectWithTag("FirePoint").transform;
	}

	void OnEnable()
	{
		m_timeTravelled = 0.0f;
		transform.position = firePoint.position;

	}


	void Update () {
		if (m_hasMaxTime)
		{
			m_timeTravelled += Time.deltaTime;

			if (m_timeTravelled > m_maxTime)
			{
				this.gameObject.SetActive(false);
			}
		}
	}
}