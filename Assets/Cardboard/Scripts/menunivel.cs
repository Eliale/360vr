using UnityEngine;
using System.Collections;


public class menunivel : MonoBehaviour {

   
    public string usernamestring = string.Empty;
    public string passwordstring = string.Empty;

    //private string url = "http://julia-tareaito.rhcloud.com/";
    private string url = "https://logical-children.herokuapp.com/users/authentication.txt?";

    void OnGUI()
    {
        GUI.Label(new Rect((Screen.width / 2) - 300, (Screen.height / 2) - 140, (Screen.width)*0.20f, (Screen.width) * 0.25f), "username");
 
        usernamestring = GUI.TextField(new Rect((Screen.width / 2) -200, (Screen.height / 2)-140, (Screen.width) * 0.40f, (Screen.width) * 0.04f), usernamestring,10);
        GUI.Label(new Rect((Screen.width / 2) - 300, (Screen.height / 2) - 45, (Screen.width) * 0.12f, (Screen.width) * 0.25f), "password");
        passwordstring = GUI.TextField(new Rect((Screen.width / 2) - 200, (Screen.height / 2) -20, (Screen.width) * 0.40f, (Screen.width) * 0.04f), passwordstring,10);
        
        if (GUI.Button(new Rect((Screen.width / 2) - 200, (Screen.height / 2)+70, (Screen.width) * 0.40f, (Screen.width) * 0.04f), "Ingresar "))

            {
            verificar(usernamestring, passwordstring);
        }

    }
   
    void verificar(string usernamestring, string passwordstring)
    {

        url = "https://logical-children.herokuapp.com/users/authentication.txt?";
        url = url + "username="+ usernamestring;
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
            Debug.Log(serviceData);
            if (www.text == "OK")
            {
                Application.LoadLevel("DemoScene");
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
                Application.LoadLevel("DemoScene");
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
