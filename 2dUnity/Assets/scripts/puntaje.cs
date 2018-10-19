using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class puntaje : MonoBehaviour {

    public float puntajeGanado = 0f;
    public Text textoPuntaje1;
    public Text textoPuntaje2;
    public Text textoPuntaje3;
    public bool reset = false;

    // Use this for initialization
    void Start () {
        puntajeGanado = 0f;	
	}
	
	// Update is called once per frame
	void Update () {
        puntajeGanado = puntajeGanado + Time.deltaTime * 100;
        MuestraEnpantalla();
	}

    public void MuestraEnpantalla() {
        if (Application.loadedLevel == 1)
        {
            puntajeGanado = (int)puntajeGanado;
            textoPuntaje1.text = "Puntaje :" + puntajeGanado;

        }
        else {
            //if (Application.loadedLevel == 2)
            //{
            //    puntajeGanado = (int)puntajeGanado;
            //    textoPuntaje1.text = "Puntaje :" + puntajeGanado;

            //}
        }
    }

    //Guardar el puntaje
    public void guardarPuntaje(string clave,int puntaje)
    {
        PlayerPrefs.SetInt(clave, puntaje);
    }
}
