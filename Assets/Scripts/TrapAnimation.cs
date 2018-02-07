using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapAnimation : MonoBehaviour {

//	public GameObject TrapStartAnimation;
	public Animator animation;

	void Start()
	{
		animation = GetComponent<Animator> ();
		animation.speed = 0;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("OnTriggerEnter");
		//animation.enabled = true;
		//TrapStartAnimation.GetComponent<Animator> ().Play ("BearTrap");
		animation.speed = 1;
	}
}