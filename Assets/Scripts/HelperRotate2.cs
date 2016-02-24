using UnityEngine;
using System.Collections;

public class HelperRotate2 : MonoBehaviour
{
	#region Fields

	[SerializeField]
	private bool rotate;

	[SerializeField]
	private float rotationSpeed;

	#endregion

	#region Methods

	void Start()
	{
		if (this.rotationSpeed == null)
			this.rotationSpeed = 0f;
	}	

	float rotationX   = 0;
	float rotationY  = 0;

	void Update()
	{
	
	}

	void OnMouseDrag() {
		Debug.Log("Rotate 2222222222222");
		rotationX += Input.GetAxis("Mouse X") ;
		
		if ( Input.GetMouseButton(0) && !Input.GetKey("left alt"))
		{
			
			transform.rotation = Quaternion.Euler(0, -rotationX*5, 0);
		}
	}
	#endregion
}
