using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class cubosarit : MonoBehaviour {

    //public string acargar;
    private int npregunta = variables.npa;
    private int preguntaactual = variables.npa;
    private float ini;
    private float tiempo = variables.tiempo;
    private bool fun;
    public int numerocubo;
    private int respuesta = 0;
    private string url = "https://logical-children.herokuapp.com/users/authentication.txt?";

    void Awake()
    {
        
        if ((npregunta == 1) && (variables.p1.Contains("+")))
        {
            respuesta = (Convert.ToInt32(variables.p1.Split('+')[0])) + (Convert.ToInt32(variables.p1.Split('+')[1])); ;
        }
        if ((npregunta == 1) && (variables.p1.Contains("-")))
        {
            respuesta = (Convert.ToInt32(variables.p1.Split('-')[0])) - (Convert.ToInt32(variables.p1.Split('-')[1])); ;
        }
        if ((npregunta == 2) && (variables.p2.Contains("+")))
        {
            respuesta = (Convert.ToInt32(variables.p2.Split('+')[0])) + (Convert.ToInt32(variables.p2.Split('+')[1])); ;
        }
        if ((npregunta == 2) && (variables.p2.Contains("-")))
        {
            respuesta = (Convert.ToInt32(variables.p2.Split('-')[0])) - (Convert.ToInt32(variables.p2.Split('-')[1])); ;
        }
        if ((npregunta == 3) && (variables.p3.Contains("+")))
        {
            respuesta = (Convert.ToInt32(variables.p3.Split('+')[0])) + (Convert.ToInt32(variables.p3.Split('+')[1])); ;
        }
        if ((npregunta == 3) && (variables.p3.Contains("-")))
        {
            respuesta = (Convert.ToInt32(variables.p3.Split('-')[0])) - (Convert.ToInt32(variables.p3.Split('-')[1])); ;
        }
        variables.respuesta = respuesta;
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
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = ""+ (Time.time - ini);

            if ((Time.time - ini) >= tiempo)
            {
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "CARGADO!!!!";
                fun = false;
                //se evalua la respuesta para saber si ser pasa al siguente nivel

                int op = 0;
                

                if ((npregunta == 1) && (numerocubo==1))
                {
                    op = Convert.ToInt32(variables.r11);
                }
                if ((npregunta == 2) && (numerocubo == 1))
                {
                    op = Convert.ToInt32(variables.r12);
                }
                if ((npregunta == 3) && (numerocubo == 1))
                {
                    op = Convert.ToInt32(variables.r13);
                }

                if ((npregunta == 1) && (numerocubo == 2))
                {
                    op = Convert.ToInt32(variables.r21);
                }
                if ((npregunta == 2) && (numerocubo == 2))
                {
                    op = Convert.ToInt32(variables.r22);
                }
                if ((npregunta == 3) && (numerocubo == 2))
                {
                    op = Convert.ToInt32(variables.r23);
                }

                if ((npregunta == 1) && (numerocubo == 3))
                {
                    op = Convert.ToInt32(variables.r31);
                }
                if ((npregunta == 2) && (numerocubo == 3))
                {
                    op = Convert.ToInt32(variables.r32);
                }
                if ((npregunta == 3) && (numerocubo == 3))
                {
                    op = Convert.ToInt32(variables.r33);
                }
                
                if (op == respuesta)
                {
                    npregunta = npregunta + 1;
                    url = "https://logical-children.herokuapp.com/students/history?";
                    GameObject.Find("letrero").GetComponent<TextMesh>().text = "la respuesta es:" + variables.respuesta;
					url = url + "student_id=" + variables.id + "&nivel=" + (variables.modo - 1) + "&intentos_fallidos=" + variables.intentos_fallidos + "&modulo_evaluado=" + 0 + "&num_pregunta=" + preguntaactual + "&acerto_pregunta=" + "1";
                    Debug.Log(url);
                    WWW www = new WWW(url);
                    StartCoroutine("GetdataEnumerator", www);
                    variables.intentos_fallidos = 0;
                }
                else
                {
                    variables.intentos_fallidos = variables.intentos_fallidos + 1;
                    url = "https://logical-children.herokuapp.com/students/history?";

					url = url + "student_id=" + variables.id + "&nivel=" + (variables.modo - 1) + "&intentos_fallidos=" + variables.intentos_fallidos + "&modulo_evaluado=" + 0 + "&num_pregunta=" + preguntaactual + "&acerto_pregunta=" + "0";
                    Debug.Log(url);
                    WWW www = new WWW(url);
                    StartCoroutine("GetdataEnumerator", www);
                }

                

                if (npregunta > 3)
                {
                    npregunta = 1;
                    variables.npa = 1;
                    variables.m1 = true;
                    SceneManager.LoadScene("DemoScene");
                }
                else
                {
                    variables.npa = npregunta;
                    SceneManager.LoadScene("ari1");

                }
            }
        }
    }



IEnumerator GetdataEnumerator(WWW www)
{
    //Wait for request to complete

    yield return www;

    if (www.error == null)
    {

        string serviceData = www.text;

        if (serviceData == "OK")
        {
                Debug.Log("Datos ENVIADOS CON EXITO");
            }
        else
        {
            Debug.Log("Datos erroneos");
        }
    }
    else
    {
        Debug.Log(www.error);
    }
}



}