using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class presenta : MonoBehaviour {



    public GUIStyle estilo;

    void OnGUI()
    {
        

        if (GUI.Button(new Rect((Screen.width / 2) * 0.4f, (Screen.height / 2) * 0.95f, (Screen.width) * 0.60f, (Screen.height) * 0.20f), "Tutorial", estilo))
        {
            SceneManager.LoadScene("tuto");
        }

        if (GUI.Button(new Rect((Screen.width / 2) * 0.4f, (Screen.height) * 0.75f, (Screen.width) * 0.60f, (Screen.height) * 0.20f), "Ingresar", estilo))
        {
            SceneManager.LoadScene("menu");
        }
    }

    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
