using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropSpawner : MonoBehaviour {

    public GameObject prefab1;

   // float randX;
   public Vector2[] whereToSpawn;
    //public float spawnRate = 2f;
   // float nextSpawn = 0.0f;


	// Use this for initialization
	void Start () {
		int randomNumber = Random.Range(0, whereToSpawn.Length-1);
        transform.position = whereToSpawn[randomNumber];
	}
	
	// Update is called once per frame
	void Update () {
		
        
        
	}
}
