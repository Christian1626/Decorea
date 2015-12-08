using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class UIMenuManager : MonoBehaviour 
{
	#region Fields
	[SerializeField]
	public GameObject goAction;
	
	[SerializeField]
	public GameObject goConfig;
	
	[SerializeField]
	public GameObject goInfo;

	ApplicationManager applicationManager;
	Rect windowRect = new Rect(250, 310, 290, 120);
	//string labelAction;
	Text labelAction;
	Text labelInfo;
	Text labelConfig;
	#endregion
	
	#region Methods
	
	void Start()
	{
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();

		Text labelAction = goAction.GetComponent<Text>();
		Text labelInfo = goInfo.GetComponent<Text>(); 
		Text labelConfig = goConfig.GetComponent<Text>(); 

		//Attribut des noms au menu selon la langues
		string labelActionValue;
		string labelInfoValue;
		string labelConfigValue;

		labelAction.text =  (applicationManager.LocalMessage.Messages.TryGetValue("Action", out labelActionValue)) ? labelActionValue: string.Empty;
		labelConfig.text =  (applicationManager.LocalMessage.Messages.TryGetValue("Config", out labelConfigValue)) ? labelConfigValue: string.Empty;
		labelInfo.text =  (applicationManager.LocalMessage.Messages.TryGetValue("Info", out labelInfoValue)) ? labelInfoValue: string.Empty;
		
	}
	

	/*
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
