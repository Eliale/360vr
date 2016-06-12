using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlcubos : MonoBehaviour, ICardboardGazeResponder
{
    public string acargar;
    private float ini;
    private float tiempo=variables.tiempo;
    private bool fun;
    void Start()
    {

    }

    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = Color.green;
        ini=Time.time;
        fun = true;
        GameObject.Find("letrero").GetComponent<TextMesh>().text = "car" + Time.time;
    }

    public void OnGazeEnter()
    {
        throw new NotImplementedException();
    }

    public void OnGazeExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("letrero").GetComponent<TextMesh>().text = "";
        fun = false;
    }

    public void OnGazeTrigger()
    {
        throw new NotImplementedException();
    }
    void Update()
    {
        if(fun)
        {
            GameObject.Find("letrero").GetComponent<TextMesh>().text = "cargando...\n"+ (int)(Time.time - ini);
            if ((Time.time-ini)>=tiempo )
            {
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "CARGADO!!!!";
                fun = false;
                SceneManager.LoadScene("ari1");
            }
        }
    }
}

