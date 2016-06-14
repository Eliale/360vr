using UnityEngine;
using System.Collections;
using System;

public class stuto : MonoBehaviour {
    public int numerocubo;
    private float ini;
    private bool fun;
    private float tiempo = variables.tiempo;
    public void SetGazedAt(bool gazedAt)
    {

        GetComponent<Renderer>().material.color = Color.green;
        ini = Time.time;
        fun = true;
        //GameObject.Find("letrero").GetComponent<TextMesh>().text = "   " + "Evaluando!!!!";
    }

    public void OnGazeEnter()
    {
        throw new NotImplementedException();
    }

    public void OnGazeExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
        GameObject.Find("p").GetComponent<TextMesh>().text = "";
        GameObject.Find("r3").GetComponent<TextMesh>().text = "";
        GameObject.Find("r2").GetComponent<TextMesh>().text = "";

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
         
            if ((Time.time - ini) >= tiempo)
            {
                //GameObject.Find("letrero").GetComponent<TextMesh>().text = "CARGADO!!!!";
                fun = false;

                if (numerocubo == 1)
                {
                    GameObject.Find("r2").GetComponent<TextMesh>().text = "ha elegido la esfera";
                    GameObject.Find("r3").GetComponent<TextMesh>().text = "";
                    GameObject.Find("p").GetComponent<TextMesh>().text = "";
                }
                if (numerocubo == 2)
                {
                    GameObject.Find("r3").GetComponent<TextMesh>().text = "ha elegido el cubo";
                    GameObject.Find("r2").GetComponent<TextMesh>().text = "";
                    GameObject.Find("p").GetComponent<TextMesh>().text = "";
                }
                if (numerocubo == 3)
                {
                    GameObject.Find("p").GetComponent<TextMesh>().text = "ha elegido el cilindro";
                    GameObject.Find("r3").GetComponent<TextMesh>().text = "";
                    GameObject.Find("r2").GetComponent<TextMesh>().text = "";
                }

            }
        }
    }
}
