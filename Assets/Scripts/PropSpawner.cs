using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpawner : MonoBehaviour {

    //made by Kiia

   public GameObject prefab1;
   public Vector2[] whereToSpawn;
   


	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range(0, whereToSpawn.Length-1);
        transform.position = whereToSpawn[randomNumber];
	}
	
	// Update is called once per frame
	void Update () {
		
        
        
	}
}
