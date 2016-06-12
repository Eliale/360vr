using UnityEngine;
using System.Collections;
using System;

public class prueba : MonoBehaviour, ICardboardGazeResponder{

	// Use this for initialization
	void Start () {
	
	}

    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = Color.green ;
        GameObject.Find("letrero").GetComponent<TextMesh>().text = "cargando!!!";
    }

    public void OnGazeEnter()
    {
        throw new NotImplementedException();
    }

    public void OnGazeExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("letrero").GetComponent<TextMesh>().text = "nada";
    }

    public void OnGazeTrigger()
    {
        throw new NotImplementedException();
    }
}
