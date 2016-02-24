using UnityEngine;
using System.Collections;

public class TriggerCollider : MonoBehaviour {
	void OnCollisionEnter(Collision collision) {
		Debug.Log("COLLISION  ENTER!!!!");
		gameObject.GetComponent<Renderer>().material.color = Color.red;
	}

	void OnCollisionExit(Collision collision) {
		Debug.Log("COLLISION EXIT!!!!");
		gameObject.GetComponent<Renderer>().material.color = Color.gray;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("Trigger ENTER2: "+other.transform.name);
		gameObject.GetComponent<Renderer>().material.color = Color.red;
		
		
	}

	void OnTriggerExit(Collider other) {
		Debug.Log("Trigger EXIT!!!!");
		gameObject.GetComponent<Renderer>().material.color = Color.gray;
	}

	/*void OnTriggernStay(Collision collision) {
		Debug.Log("TRIGGER STAUYYY !!!!");
	}



	void OnCollisionStay(Collision collision) {
		Debug.Log("COLLISION STAY !!!!");
		gameObject.GetComponent<Renderer>().material.color = Color.red;
	}

	void OnTriggerEnter(Collider other) {
		Debug.Log("COLLISION 2: "+other.transform.name);
		//other.GetComponent<Renderer>().material.color = Color.red;
		if(other.transform.name == "CommodeCollider") {
			current.GetComponent<Renderer>().material.color = Color.red;
			commode.GetComponent<Renderer>().material.color = Color.red;
		} else if(other.transform.name == "FauteuilCollider") {
			current.GetComponent<Renderer>().material.color = Color.red;
			fauteuil.GetComponent<Renderer>().material.color = Color.red;
		}


	}

	void OnTriggerExit(Collider other) {
		Debug.Log("EXIT : "+other.transform.name);
		//other.GetComponent<Renderer>().material.color = Color.red;
		if(other.transform.name == "CommodeCollider") {
			current.GetComponent<Renderer>().material.color = Color.gray;
			commode.GetComponent<Renderer>().material.color = Color.gray;
		} else if(other.transform.name == "FauteuilCollider") {
			current.GetComponent<Renderer>().material.color = Color.gray;
			fauteuil.GetComponent<Renderer>().material.color = Color.gray;
		}

	}

	/*void OnCollisionStay(Collision collisionInfo) {
		Debug.Log("COLLISION 3: "+collisionInfo);
		foreach (ContactPoint contact in collisionInfo.contacts) {
			Debug.DrawRay(contact.point, contact.normal * 10, Color.white);
		}
	}*/


}
