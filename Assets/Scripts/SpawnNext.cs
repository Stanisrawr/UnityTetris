using UnityEngine;
using System.Collections;

public class SpawnNext : MonoBehaviour {

	public GameObject[] Group;

	void Start() {
		// Spawn initial Group
		Spawn_Next();
	}


	public void Spawn_Next()
	{
		int rand;
		rand = Random.Range (0, 6);

		Instantiate (Group [rand],transform.position,Quaternion.identity);



	}


}
