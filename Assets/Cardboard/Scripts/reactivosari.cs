using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reactivosari : MonoBehaviour {

    private int estadio = variables.npa;
    private float inicio;
    
    void Awake () {
       
        inicio= Time.time;
    }
	
	void Update () {
        Debug.Log(estadio);
        if (estadio==2)
        {
            GameObject.Find("p").GetComponent<TextMesh>().text = variables.p2;
            GameObject.Find("r1").GetComponent<TextMesh>().text = variables.r12;
            GameObject.Find("r2").GetComponent<TextMesh>().text = variables.r22;
            GameObject.Find("r3").GetComponent<TextMesh>().text = variables.r32;
        }
        if (estadio == 3)
        {
            GameObject.Find("p").GetComponent<TextMesh>().text = variables.p3;
            GameObject.Find("r1").GetComponent<TextMesh>().text = variables.r13;
            GameObject.Find("r2").GetComponent<TextMesh>().text = variables.r23;
            GameObject.Find("r3").GetComponent<TextMesh>().text = variables.r33;
        }
        if (estadio == 1)
        {
            GameObject.Find("p").GetComponent<TextMesh>().text = variables.p1;
            GameObject.Find("r1").GetComponent<TextMesh>().text = variables.r11;
            GameObject.Find("r2").GetComponent<TextMesh>().text = variables.r21;
            GameObject.Find("r3").GetComponent<TextMesh>().text = variables.r31;
        }
        if (variables.modo == 1)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time-inicio) >= variables.timepo1)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + variables.respuesta;
                if ((Time.time - inicio) >= (variables.timepo1+1.5))
                {
                    SceneManager.LoadScene("ari1");
                }
            }
        }
        if (variables.modo == 2)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo2)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + variables.respuesta;
                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                    SceneManager.LoadScene("ari1");
                }
            }
        }
        if (variables.modo == 3)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo3)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n"+variables.respuesta;
                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                    SceneManager.LoadScene("ari1");
                }
            }
        }

    }
}
