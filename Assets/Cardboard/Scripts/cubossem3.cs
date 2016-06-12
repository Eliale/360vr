using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class cubossem3 : MonoBehaviour {


    //public string acargar;
    private int npregunta = variables.npa;
    private float ini;
    private float tiempo = variables.tiempo;
    private bool fun;
    public int numerocubo;
    private int respuesta = 0;

    void Awake()
    {

    }

    public void SetGazedAt(bool gazedAt)
    {

        GetComponent<Renderer>().material.color = Color.green;
        ini = Time.time;
        fun = true;
        GameObject.Find("letrero").GetComponent<TextMesh>().text = "   " + "Evaluando!!!!";
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

        if (fun)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = ""+ (int)(Time.time - ini);

            if ((Time.time - ini) >= tiempo)
            {
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "CARGADO!!!!";
                fun = false;

                if (numerocubo == 1)
                {
                    variables.npa = 3;
                    GameObject.Find("letrero").GetComponent<TextMesh>().text = "la respuesta es: manzana";
                    SceneManager.LoadScene("DemoScene");

                }
            }
        }
    }
}
