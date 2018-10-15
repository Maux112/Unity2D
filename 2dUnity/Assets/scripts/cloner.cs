using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloner : MonoBehaviour {
    public GameObject[] objects;
    public float min = 1f, max = 2f;
	// Use this for initialization
	void Start () {
        instanciar();
	}
	
	// Update is called once per frame
	void instanciar () {
        Instantiate(objects[Random.Range(0, objects.Length)], transform.position, Quaternion.identity);
        Invoke("instanciar", Random.Range(min,max));
		
	}
}
