using UnityEngine;
using System.Collections;

public class UIInfoManager : MonoBehaviour 
{
	#region Fields
	ApplicationManager applicationManager;
	string labelInfoValue;
	string labelVersionValue;
	string labelButtonMenuValue;
	GUIText labelVersion;
	GameObject labelInfo;
	#endregion
	
	#region Methods
	void Start()
	{
		//Récupère les gameobjects
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		this.labelVersion = GameObject.Find ("LabelVersion").GetComponent<GUIText> ();
		//this.labelInfo = GameObject.Find ("LabelInfo").GetComponent<GUIText> ();
		this.labelInfo = GameObject.Find ("LabelInfo").GetComponent<GameObject> ();
		
		DefineLabels ();
	}
	
	void DefineLabels()
	{
		//version
		this.labelVersionValue = (applicationManager.LocalMessage.Messages.TryGetValue("InfoVersion", out  labelVersionValue)) ?   labelVersionValue : string.Empty;
		this.labelVersion.text = string.Concat(this.labelVersionValue , this.applicationManager.Version);

		//info
		this.labelInfoValue = string.Empty;
		//GameObject.Find("Canvas").transform.Find("LabelInfo").GetComponent<GUIText>().text = (applicationManager.LocalMessage.Messages.TryGetValue("InfoAbout", out  labelInfoValue)) ?   labelInfoValue : string.Empty;
		
		this.labelButtonMenuValue = (applicationManager.LocalMessage.Messages.TryGetValue("ButtonBack", out  labelButtonMenuValue)) ?   labelButtonMenuValue : string.Empty;
	}

	public void OnClickMainMenu() {
		this.applicationManager.SceneToLoad="MainMenu";
		Application.LoadLevel("Loading");
	}
	#endregion
}
