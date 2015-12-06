using UnityEngine;
using System.Collections;

public class UIConfigurationManager : MonoBehaviour 
{
	#region Fields
	ApplicationManager applicationManager;
	Rect windowRect;
	string labelConfiguration;
	#endregion
	
	#region Methods
	void Start()
	{
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		this.windowRect = new Rect(250, 310, 280, 120);	
		
		DefineLabels ();
	}
	
	void DefineLabels()
	{
		this.labelConfiguration = (applicationManager.LocalMessage.Messages.TryGetValue("LabelConfiguration", out  this.labelConfiguration)) ?   this.labelConfiguration : string.Empty;
	}
	
	void OnGUI() 
	{
		GUI.Label(new Rect(0,0,200,30),"toto");	
		windowRect = GUI.Window(0,windowRect , WindowAction, this.labelConfiguration);
		
	}
	
	void WindowAction(int windowID) 
	{
		if (GUI.Button (new Rect (50, 50, 80, 40), "FR")) 
		{
			this.applicationManager.CurrentLanguage = CultureMessage.CultureFile.FR;
			this.applicationManager.ManageLocalization();
			this.applicationManager.SceneToLoad="MainMenu";
			Application.LoadLevel("Loading");
		}
		if (GUI.Button (new Rect (150, 50, 80, 40), "US")) 
		{
			this.applicationManager.CurrentLanguage = CultureMessage.CultureFile.US;
			this.applicationManager.ManageLocalization();
			this.applicationManager.SceneToLoad="MainMenu";
			Application.LoadLevel("Loading");
		}
	}
	#endregion
}
