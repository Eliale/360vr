using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reactivore3 : MonoBehaviour {

    private int estadio = variables.npa;
    private float inicio;
    private string url = "https://logical-children.herokuapp.com/users/authentication.txt?";
    private int preguntaactual = variables.npa;
    void Awake()
    {

        inicio = Time.time;
    }

    void Update()
    {


        if (variables.modo == 1)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo1)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + "cubo";

                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                    url = "https://logical-children.herokuapp.com/students/history?";
                    variables.intentos_fallidos = variables.intentos_fallidos + 1;
                    url = url + "student_id=" + variables.id + "&nivel=" + (variables.modo - 1) + "&intentos_fallidos=" + variables.intentos_fallidos + "&modulo_evaluado=" + 2 + "&num_pregunta=" + preguntaactual + "0";
                    Debug.Log(url);
                    WWW www = new WWW(url);
                    StartCoroutine("GetdataEnumerator", www);
                    SceneManager.LoadScene("ser3");
                }
            }
        }
        if (variables.modo == 2)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo2)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + "cubo";

                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                    url = "https://logical-children.herokuapp.com/students/history?";
                    variables.intentos_fallidos = variables.intentos_fallidos + 1;
                    url = url + "student_id=" + variables.id + "&nivel=" + (variables.modo - 1) + "&intentos_fallidos=" + variables.intentos_fallidos + "&modulo_evaluado=" + 2 + "&num_pregunta=" + preguntaactual + "0";
                    Debug.Log(url);
                    WWW www = new WWW(url);
                    StartCoroutine("GetdataEnumerator", www);
                    SceneManager.LoadScene("ser3");
                }
            }
        }
        if (variables.modo == 3)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo3)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + "cubo";
                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                    url = "https://logical-children.herokuapp.com/students/history?";
                    variables.intentos_fallidos = variables.intentos_fallidos + 1;
                    url = url + "student_id=" + variables.id + "&nivel=" + (variables.modo - 1) + "&intentos_fallidos=" + variables.intentos_fallidos + "&modulo_evaluado=" + 2 + "&num_pregunta=" + preguntaactual + "0";
                    Debug.Log(url);
                    WWW www = new WWW(url);
                    StartCoroutine("GetdataEnumerator", www);
                    SceneManager.LoadScene("ser3");
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
