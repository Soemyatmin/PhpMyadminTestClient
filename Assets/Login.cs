using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

	public InputField iName;
	public InputField iPass;

	void Start () {
		string username = PlayerPrefs.GetString ("iName", "0");
		string password = PlayerPrefs.GetString ("iPass", "0");
		if(username == "0" ||password == "0"){
			return;
		}else{
			LogintoDB (username, password);
		}
	}


	public void LoginBtn(){
		if (CheckingInternet.INTERNET_STATUS ()) {
			if (iName.text.ToString ().Trim () == "" || iPass.text.ToString ().Trim () == "") {
				Debug.Log ("Type Full");
			} else {
				StartCoroutine (LogintoDB (iName.text.ToString ().Trim (), iPass.text.ToString ().Trim ()));
			}
		} else {
			Debug.Log ("No internet");
		}
	}

	IEnumerator LogintoDB(string username, string password){
		WWWForm form = new WWWForm ();
		form.AddField ("usernamepost", username);
		form.AddField ("userpasswordpost", password);
		WWW www = new WWW ("http://ec2-52-221-227-188.ap-southeast-1.compute.amazonaws.com/Login.php", form);
		print ("Login Loading");	
		yield return www;
		print ("Fisished");
		print ("" + www.text);
	}

}
