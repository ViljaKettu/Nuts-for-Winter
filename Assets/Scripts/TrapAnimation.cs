using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAnimation : MonoBehaviour {

//	made by Kiia
	public Animator animation;

	void Start()
	{
		animation = GetComponent<Animator> ();
		animation.speed = 0;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("OnTriggerEnter");
		animation.speed = 1;
	}
}