using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using System;

public class regresar : MonoBehaviour {
    public string lugar;
    private float ini;
    private float tiempo = variables.tiempo;
    private bool fun;
    public void SetGazedAt(bool gazedAt)
    {
        GetComponent<Renderer>().material.color = Color.green;
        ini = Time.time;
        fun = true;
    }

    public void OnGazeEnter()
    {
        throw new NotImplementedException();
    }

    public void OnGazeExit()
    {
        GetComponent<Renderer>().material.color = Color.red;
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
                fun = false;
                if (variables.npa>1)
                {
                    variables.npa = variables.npa - 1;
                }
                
                SceneManager.LoadScene("ari1");
            }
        }
    }
}
