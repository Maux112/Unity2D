﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class barrer : MonoBehaviour {

    public GameObject GameObject;
    private puntaje puntaje_script;

    private void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
        else {
            if (collision.gameObject.transform.parent)
            {
                Destroy(collision.gameObject.gameObject.transform.parent);
            }
            else {
                Destroy(collision.gameObject);
            }
        }
    }
}
