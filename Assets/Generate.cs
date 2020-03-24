using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Generate : MonoBehaviour {
    public GameObject platform1;
    public GameObject platform2;

	public int numberOfPlatforms = 200;
	public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 1.5f;

	float random_naught = 0f;
	public float random = 1.5f;

	// Use this for initialization
	void Start () {
		Vector3 spawnPosition = new Vector3();

		for (int i = 0; i < numberOfPlatforms; i++)
		{
			spawnPosition.y += UnityEngine.Random.Range(minY, maxY);
			spawnPosition.x = UnityEngine.Random.Range(-levelWidth, levelWidth);

			if ((int) Math.Floor(UnityEngine.Random.Range(random_naught,random)) != 0){
			    Instantiate(platform1, spawnPosition, Quaternion.identity);
			} else {
			    Instantiate(platform2, spawnPosition, Quaternion.identity);
			}
		}
	}
}