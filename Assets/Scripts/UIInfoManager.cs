using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIInfoManager : MonoBehaviour 
{
	#region Fields
	[SerializeField]
	public GameObject goInfo;
	
	[SerializeField]
	public GameObject goVersion;

	[SerializeField]
	public GameObject goButtonMenu;

	ApplicationManager applicationManager;
	string labelInfoValue;
	string labelVersionValue;
	string labelButtonMenuValue;
	Text labelButtonMenu;
	Text labelInfo;
	Text labelVersion;
	#endregion
	
	#region Methods
	void Start()
	{
		//Récupère les gameobjects
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		this.labelInfo = goInfo.GetComponent<Text>();
		this.labelVersion = goVersion.GetComponent<Text>(); 
		this.labelButtonMenu = goButtonMenu.GetComponent<Text>(); 
		DefineLabels ();
	}
	
	void DefineLabels()
	{
		this.labelVersionValue = (applicationManager.LocalMessage.Messages.TryGetValue("InfoVersion", out  labelVersionValue)) ?   labelVersionValue : string.Empty;
		this.labelVersion.text = string.Concat(this.labelVersionValue , this.applicationManager.Version);

		Debug.Log ("Version:"+this.applicationManager.Version);
		/*this.labelVersion.text = (applicationManager.LocalMessage.Messages.TryGetValue("InfoVersion", out  labelVersionValue)) ?   labelVersionValue : string.Empty;
		Debug.Log("Version: "+ labelVersionValue);
		labelVersion.text = "44";*/
		this.labelInfo.text = (applicationManager.LocalMessage.Messages.TryGetValue("InfoAbout", out  labelInfoValue)) ?   labelInfoValue : string.Empty;
		
		this.labelButtonMenu.text = (applicationManager.LocalMessage.Messages.TryGetValue("ButtonBack", out  labelButtonMenuValue)) ?   labelButtonMenuValue : string.Empty;
	}

	public void OnClickMainMenu() {
		this.applicationManager.SceneToLoad="MainMenu";
		Application.LoadLevel("Loading");
	}
	#endregion
}
