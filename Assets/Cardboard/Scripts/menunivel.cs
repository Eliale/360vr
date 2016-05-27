using UnityEngine;
using System.Collections;


public class menunivel : MonoBehaviour {

   
    public string usernamestring = string.Empty;
    public string passwordstring = string.Empty;
    private string url = "http://julia-tareaito.rhcloud.com/";

    void OnGUI()
    {
        GUI.Label(new Rect((Screen.width / 2) - 155, (Screen.height / 2) - 85, 150, 35), "username");
        usernamestring = GUI.TextField(new Rect((Screen.width / 2) -80, (Screen.height / 2)-90, 150,35), usernamestring,10);
        GUI.Label(new Rect((Screen.width / 2) - 155, (Screen.height / 2) - 45, 150, 35), "password");
        passwordstring = GUI.TextField(new Rect((Screen.width / 2) - 80, (Screen.height / 2) - 45, 150, 35), passwordstring,10);
        
        if (GUI.Button(new Rect((Screen.width / 2) - 50, (Screen.height / 2), 100, 50), "Ingresar "))
            {
            verificar(usernamestring, passwordstring);
        }

    }
   
    void verificar(string usernamestring, string passwordstring)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", usernamestring);
        form.AddField("password", passwordstring);
        WWW www = new WWW(url, form);
        StartCoroutine("WaitForRequest", www);
    }
    // Use this for initialization
    void Start () {
      
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
