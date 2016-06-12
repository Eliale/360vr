using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class reactivossem : MonoBehaviour {

    private int estadio = variables.npa;
    private float inicio;

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
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + "helicóptero";
                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                   SceneManager.LoadScene("sem1");
                }
            }
        }
        if (variables.modo == 2)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo2)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + "helicóptero";
                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                    SceneManager.LoadScene("sem1");
                }
            }
        }
        if (variables.modo == 3)
        {
            //GameObject.Find("letrero").GetComponent<TextMesh>().text = "timepo" + (Time.time - inicio);
            if ((Time.time - inicio) >= variables.timepo3)
            {
                GameObject.Find("p").GetComponent<TextMesh>().text = "";
                GameObject.Find("letrero").GetComponent<TextMesh>().text = "intentalo de nuevo\nla respuesta es:\n" + "helicóptero";
                if ((Time.time - inicio) >= (variables.timepo1 + 1.5))
                {
                   SceneManager.LoadScene("sem1");
                }
            }
        }

    }
}
