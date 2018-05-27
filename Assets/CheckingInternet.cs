using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckingInternet : MonoBehaviour {

	public static bool INTERNET_STATUS () {
		if (Application.internetReachability == NetworkReachability.NotReachable) {
			return false;
		}
		return true;
	}

}
