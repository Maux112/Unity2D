using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paramuñecomenu : MonoBehaviour {
    public GameObject player;
    public float max, posicionX, posiciony;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (player.transform.position.x >= max) {
            player.transform.position = new Vector2(posicionX, posiciony);
        }
	}
}
