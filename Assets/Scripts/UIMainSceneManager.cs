using UnityEngine;
using System;
using System.Collections;

public class UIMainSceneManager : MonoBehaviour 
{
	#region Fields
	
	ApplicationManager applicationManager;
	
	[SerializeField]
	private Texture2D iconZoomIn;
	[SerializeField]
	private Texture2D iconZoomOut;
	[SerializeField]
	private Texture2D iconZoomCamera;
	[SerializeField]
	private Texture2D iconHome;
	
	#endregion
	
	#region Methods
	
	void Start () 
	{
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
	}
	
	void OnGUI()
	{
		GUI.backgroundColor = Color.clear;
		if (GUI.Button (new Rect (5, 5, 200, 200), iconHome)) 
		{
			this.applicationManager.SceneToLoad="MainMenu";
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (220, 5, 200, 200), iconZoomIn)) 
		{
			if(this.applicationManager.CurrentTrackableObject!=null)
			{
				this.applicationManager.CurrentTrackableObject.transform.localScale = new Vector3(this.applicationManager.CurrentTrackableObject.transform.localScale.x*1.3f,this.applicationManager.CurrentTrackableObject.transform.localScale.y*1.3f,this.applicationManager.CurrentTrackableObject.transform.localScale.z*1.3f);
			}
		}
		if (GUI.Button (new Rect (440, 5, 200, 200), iconZoomOut)) 
		{
			if(this.applicationManager.CurrentTrackableObject!=null)
			{
				this.applicationManager.CurrentTrackableObject.transform.localScale = new Vector3(this.applicationManager.CurrentTrackableObject.transform.localScale.x*0.7f,this.applicationManager.CurrentTrackableObject.transform.localScale.y*0.7f,this.applicationManager.CurrentTrackableObject.transform.localScale.z*0.7f);
			}
		}
		if (GUI.Button (new Rect (660, 5, 200, 200), iconZoomCamera)) 
		{
			Application.CaptureScreenshot(string.Format("Screenshot_{0}.png", DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss")));
		}
		GUI.backgroundColor = Color.white; 
	}
	
	#endregion
}
