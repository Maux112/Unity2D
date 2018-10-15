using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PASARESCENA : MonoBehaviour {

    // Use this for initialization
    public void menu()
    {
        SceneManager.LoadScene(0);
    }

    public void jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Perder()
    {
        SceneManager.LoadScene(2);
    }

}
