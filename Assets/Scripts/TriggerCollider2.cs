using UnityEngine;
using System.Collections;

public class TriggerCollider2 : MonoBehaviour {
	[SerializeField]
	public GameObject current;
	[SerializeField]
	public GameObject commode;
	[SerializeField]
	public GameObject fauteuil;
	
	public bool isCollision;
	public string collisionWith;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!isCollision) {
			if(collisionWith == "CommodeCollider") {
				current.GetComponent<Renderer>().material.color = Color.yellow;
				commode.GetComponent<Renderer>().material.color = Color.yellow;
			} else if(collisionWith == "FauteuilCollider") {
				current.GetComponent<Renderer>().material.color = Color.yellow;
				fauteuil.GetComponent<Renderer>().material.color = Color.yellow;
			}
		}
	}
	
	void OnCollisionEnter(Collision collision) {
		Debug.Log("COLLISION: "+collision);
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
		isCollision = true;
		
		//Destroy(other.gameObject);
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
		isCollision = false;
		
		//Destroy(other.gameObject);
	}
	
	/*void OnCollisionStay(Collision collisionInfo) {
		Debug.Log("COLLISION 3: "+collisionInfo);
		foreach (ContactPoint contact in collisionInfo.contacts) {
			Debug.DrawRay(contact.point, contact.normal * 10, Color.white);
		}
	}*/
	
	
}
