using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   	public Transform Spawnpoint;
	public GameObject Prefab;

	void OnTriggerEnter()
	{
	Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
	}
}
