using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class menunivel : MonoBehaviour {

   
    public string usernamestring = string.Empty;
    public string passwordstring = string.Empty;

    //private string url = "http://julia-tareaito.rhcloud.com/";
    private string url = "https://logical-children.herokuapp.com/users/authentication.txt?";

    public GUIStyle estilo;

    void OnGUI()
    {
        GUI.Label(new Rect((Screen.width / 2) *0.1f, (Screen.height / 2) *0.60f, (Screen.width)*0.12f, (Screen.height) * 0.20f), "USERNAME",estilo);
 
        usernamestring = GUI.TextField(new Rect((Screen.width / 2) *0.5f, (Screen.height / 2)*0.60f, (Screen.width) * 0.60f, (Screen.height) * 0.20f), usernamestring,100,estilo);

        GUI.Label(new Rect((Screen.width / 2) *0.1f, (Screen.height / 2) , (Screen.width) * 0.12f, (Screen.height) * 0.25f), "PASSWORD", estilo);

        passwordstring = GUI.PasswordField(new Rect((Screen.width / 2) *0.5f, (Screen.height / 2), (Screen.width) * 0.60f, (Screen.height) * 0.20f), passwordstring,'*',100, estilo);
        
        if (GUI.Button(new Rect((Screen.width / 2) *0.6f, (Screen.height )*0.80f, (Screen.width) * 0.40f, (Screen.height) * 0.15f), "LOGIN", estilo))

            {
            verificar(usernamestring, passwordstring);
        }

    }
   
    void verificar(string usernamestring, string passwordstring)
    {

        url = "https://logical-children.herokuapp.com/users/authentication.txt?";
        url = url + "username="+ usernamestring+ "&password="+ passwordstring;
        Debug.Log(url);
        WWW www = new WWW(url);
        StartCoroutine("GetdataEnumerator", www);

    }
    // Use this for initialization
    void Start () {
      
    }


    IEnumerator GetdataEnumerator(WWW www)
    {
        //Wait for request to complete

        yield return www;

        if (www.error == null)
        {

            string serviceData = www.text;
            
             if (serviceData != "SIN ACCESO")
             {
                string[] fullName = serviceData.Split(',');
                variables.id = fullName[0].Split('=')[1];
                variables.username = fullName[1].Split('=')[1];
                variables.nivel = fullName[2].Split('=')[1];
                variables.intentos_fallidos = fullName[3].Split('=')[1];
                variables.modulo_evaluado = fullName[4].Split('=')[1];
                SceneManager.LoadScene("DemoScene");
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


    IEnumerator WaitForRequest(WWW www)
    {
        yield return www;


        if (www.error == null)
        {
            Debug.Log("post Ok!: " + www.text);
            if (www.text == "OK")
            {

                SceneManager.LoadScene("DemoScene");
            }
        }
        else {
            Debug.Log("post Error: " + www.error);
        }
    }
        // Update is called once per frame
        void Update () {
	
	}
}
