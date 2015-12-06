using UnityEngine;
using System.Collections;


public class UIMenuManager : MonoBehaviour 
{
	#region Fields
	ApplicationManager applicationManager;
	Rect windowRect = new Rect(250, 310, 290, 120);
	string labelConfig;
	string labelInfo;
	string labelAction;
	string labelMainMenu;
	#endregion
	
	#region Methods
	
	void Start()
	{
		Debug.Log ("Start");
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		Debug.Log (applicationManager);
		this.labelMainMenu = this.labelConfig = this.labelAction = string.Empty;
		
		this.labelMainMenu =  (applicationManager.LocalMessage.Messages.TryGetValue("MainMenu", out labelMainMenu)) ? labelMainMenu: string.Empty;
		this.labelConfig =  (applicationManager.LocalMessage.Messages.TryGetValue("Config", out labelConfig)) ? labelConfig: string.Empty;
		this.labelInfo =  (applicationManager.LocalMessage.Messages.TryGetValue("Info", out labelInfo)) ? labelInfo: string.Empty;
		this.labelAction =  (applicationManager.LocalMessage.Messages.TryGetValue("Action", out labelAction)) ? labelAction: string.Empty;
		
	}
	
	/*void OnGUI() 
	{
		GUI.Label(new Rect(0,0,200,30),labelInfo);	
		windowRect = GUI.Window(0,windowRect , WindowAction, labelMainMenu);
	}
	
	void WindowAction(int windowID) 
	{
		if (GUI.Button (new Rect (Screen.width/2, Screen.height/2, 100, 40), this.labelConfig)) 
		{
			this.applicationManager.SceneToLoad="Configuration";
			Application.LoadLevel("Configuration");   
		}
		if (GUI.Button (new Rect (175, 20, 100, 40), this.labelInfo)) 
		{
			this.applicationManager.SceneToLoad="Information";
			Application.LoadLevel("Loading");   
		}
		if (GUI.Button (new Rect (25, 70, 250, 40), this.labelAction)) 
		{
			this.applicationManager.SceneToLoad="MainScene";
			Application.LoadLevel("Loading");   
		}
	}*/

	public void OnClickConfiguration() {
		Debug.Log ("OnClickConfiguration");
		this.applicationManager.SceneToLoad="Configuration";
		Application.LoadLevel("Configuration"); 
	}

	public void OnClickInfo() {
		Debug.Log("OnClickInfo");
		this.applicationManager.SceneToLoad="Information";
		Application.LoadLevel("Loading");
	}

	public void OnClickMainScene() {
		Debug.Log ("OnClickMainScene");
		this.applicationManager.SceneToLoad="MainScene";
		Application.LoadLevel("Loading");   
	}
	#endregion
}
