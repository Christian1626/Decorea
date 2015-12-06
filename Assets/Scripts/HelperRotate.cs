using UnityEngine;
using System.Collections;

public class HelperRotate : MonoBehaviour
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
	void OnMouseDown()
	{
		this.rotate = !this.rotate;
	}

	void Update()
	{
		if (rotate)
		{
			transform.Rotate(0f, this.rotationSpeed * Time.deltaTime, 0f);
		}
	}

	#endregion
}
