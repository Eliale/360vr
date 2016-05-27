
using UnityEngine;
using System.Collections;


public class post : MonoBehaviour {

	void Start () {

		string url = "http://192.168.2.16:8080/";

		WWWForm form = new WWWForm();
		form.AddField("var1", "value1");
		form.AddField("var2", "value2");
		WWW www = new WWW(url, form);

		StartCoroutine("WaitForRequest",www);
	}

	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;


		if (www.error == null)
		{
			Debug.Log("post Ok!: " + www.text);
		} else {
			Debug.Log("post Error: "+ www.error);
		}    


	}	

}
