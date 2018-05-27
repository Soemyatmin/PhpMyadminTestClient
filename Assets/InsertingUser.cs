using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertingUser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine (CreateUser ("Unity username1GG","Unity Password1GG", "defaultID1"));
		}
	}
	IEnumerator CreateUser(string username, string password, string androidID){
		WWWForm form = new WWWForm ();
		form.AddField ("usernamepost", username);
		form.AddField ("userpasswordpost", password);
		form.AddField ("androidpost", androidID);

		WWW www = new WWW ("http://ec2-52-221-227-188.ap-southeast-1.compute.amazonaws.com/userController.php", form);
		print ("Loading");	
		yield return www;
		print (""+www.text );
		if (www.text == "ok") {
			print ("Success");
		} else if (www.text == "error") {
			print ("Error");
		} else {
			print ("Loading");	
		}
		print (" eee" +  www.text);
	}
}
