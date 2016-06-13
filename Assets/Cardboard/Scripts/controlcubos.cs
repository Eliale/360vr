using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlcubos : MonoBehaviour, ICardboardGazeResponder
{
    public string acargar;
    private float ini;
    private float tiempo=variables.tiempo;
    private bool fun;
    void Awake()
    {
        if ((variables.m1 && variables.m2) && variables.m3)
        {
            variables.modo = variables.modo + 1;
            if (variables.modo > 3)
            {
                variables.modo = 3;
            }
            variables.m1 = false;
            variables.m2 = false;
            variables.m3 = false;
        }
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
               
                SceneManager.LoadScene(acargar);
            }
        }
    }
}

