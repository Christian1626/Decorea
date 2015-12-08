using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIConfigurationManager : MonoBehaviour 
{
	#region Fields
	[SerializeField]
	public GameObject goButtonMenu;

	ApplicationManager applicationManager;
	Rect windowRect;
	string labelConfiguration;

	string labelButtonMenuValue;
	Text labelButtonMenu;
	#endregion
	
	#region Methods
	void Start()
	{
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		this.labelButtonMenu = goButtonMenu.GetComponent<Text>(); 	
		
		DefineLabels ();
	}
	
	void DefineLabels()
	{
		//this.labelConfiguration = (applicationManager.LocalMessage.Messages.TryGetValue("LabelConfiguration", out  this.labelConfiguration)) ?   this.labelConfiguration : string.Empty;

		this.labelButtonMenuValue = (applicationManager.LocalMessage.Messages.TryGetValue("ButtonBack", out  labelButtonMenuValue)) ?   labelButtonMenuValue : string.Empty;
		this.labelButtonMenu.text = labelButtonMenuValue;
	}

	public void OnClickFR() {
		this.applicationManager.CurrentLanguage = CultureMessage.CultureFile.FR;
		this.applicationManager.ManageLocalization();
		this.applicationManager.SceneToLoad="MainMenu";
		Application.LoadLevel("Loading");
	}

	public void OnClickUS() {
		this.applicationManager.CurrentLanguage = CultureMessage.CultureFile.US;
		this.applicationManager.ManageLocalization();
		this.applicationManager.SceneToLoad="MainMenu";
		Application.LoadLevel("Loading");
	}

	public void OnClickMainMenu() {
		this.applicationManager.SceneToLoad="MainMenu";
		Application.LoadLevel("Loading");
	}
	#endregion
}
