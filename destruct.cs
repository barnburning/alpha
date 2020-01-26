using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destruct : MonoBehaviour
{
	public GameObject objToDestroy;
   	public GameObject effect;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Cat Lite")
            Instantiate(effect, objToDestroy.transform.position, objToDestroy.transform.rotation);
            Destroy(objToDestroy);
    }
}