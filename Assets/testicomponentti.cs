using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testicomponentti : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider other)
	{
		Debug.Log("OnTriggerEnter");
	//	animation.enabled = true;
		//TrapStartAnimation.GetComponent<Animator> ().Play ("BearTrap");

	}
}
