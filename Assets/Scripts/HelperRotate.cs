using UnityEngine;
using System.Collections;

public class HelperRotate : MonoBehaviour
{


	#region Fields	
	[SerializeField]
	private bool rotate;

	[SerializeField]
	private float rotationSpeed;

	ApplicationManager applicationManager;

	#endregion

	#region Methods

	void Start()
	{
		if (this.rotationSpeed == null)
			this.rotationSpeed = 0f;

		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		Debug.Log ("START:"+applicationManager);
	}	

	float rotationX   = 0;
	float rotationY  = 0;

	void Update()
	{
	
	}

	void OnMouseDrag() {
		//Debug.Log("Rotate");
		rotationX += Input.GetAxis("Mouse X") ;
		if(this.applicationManager.CurrentTrackableObject.transform.name != gameObject.transform.name) {
			this.applicationManager.CurrentTrackableObject = gameObject;
		}

		Debug.Log("CURRENT OBJECT: "+this.applicationManager.CurrentTrackableObject.transform.name);

		
		if ( Input.GetMouseButton(0) && !Input.GetKey("left alt"))
		{
			transform.rotation = Quaternion.Euler(0, -rotationX*5, 0);
		}
	}
	#endregion
}
