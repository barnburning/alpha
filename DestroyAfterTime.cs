using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour
{
    public float interval;
    // Use this for initialization
    void Start() {
        Destroy (gameObject, interval);
    }
    
    void Update () {

    }
}