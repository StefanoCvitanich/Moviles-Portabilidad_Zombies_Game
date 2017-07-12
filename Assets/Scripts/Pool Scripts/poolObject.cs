using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poolObject : MonoBehaviour {

    //public bool isSpawned = false;

	public virtual void onObjectReuse () {
		
	}

	public void destroy(){
	
		gameObject.SetActive (false);
	}
}