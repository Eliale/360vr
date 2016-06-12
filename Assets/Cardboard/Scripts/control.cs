using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class control : MonoBehaviour {

    public string user;
    public string estado;

    public string ultijuego;
    public GUIStyle estilo;
    

    void Awake()
    {
      //GameObject.Find("letrero").GetComponent<TextMesh>().text = "Ganaste!!!";
    }
    void Start () {
        
    }

    void OnGUI()
    {
        user = variables.username;
        GUI.Box(new Rect((Screen.width) * 0.85f, (Screen.height / 2) * 0.10f, (Screen.width) * 0.12f, (Screen.height) * 0.08f), "Usuario");
        GUI.Label(new Rect((Screen.width ) * 0.85f, (Screen.height / 2) * 0.11f, (Screen.width) * 0.12f, (Screen.height) * 0.10f), ""+user,estilo);

    }
    void Update()
    {
       // GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentelo de nuevo";
    }
}
