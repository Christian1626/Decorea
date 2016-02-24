using UnityEngine;
using System.Collections;

public class ApplicationManager : MonoBehaviour {

	#region Fields
	[SerializeField]
	private CultureMessage localMessage;

	[SerializeField]
	private CultureMessage.CultureFile currentLanguage;

	[SerializeField]
	private string version;

	private string sceneToLoad;

	[SerializeField]
	private GameObject currentTrackableObject;

	#endregion

	#region Methods

	void Start() {
		Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
	public string Version {
		get { return this.version; }
	}

	public string SceneToLoad {
		get { return this.sceneToLoad; }
		set { this.sceneToLoad = value;}
	}



	public CultureMessage LocalMessage {
		get {
			if(this.localMessage == null) {
				this.localMessage = new CultureMessage();
				this.localMessage.LoadMessages(this.currentLanguage);
			}
			return this.localMessage;
		}
		set { localMessage = value; }
	}

	public CultureMessage.CultureFile CurrentLanguage {
		get { return this.currentLanguage; }
		set {
			this.currentLanguage = value;
			this.localMessage.LoadMessages(this.currentLanguage);
			PlayerPrefs.SetString("currentLanguage",this.currentLanguage.ToString());
			PlayerPrefs.Save();
		}
	}

	public GameObject CurrentTrackableObject 
	{
		get 
		{
			return currentTrackableObject;
		}
		set 
		{
			currentTrackableObject = value;
		}
	}

	void Update() {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if(Application.loadedLevelName == "MainMenu") {
				Application.Quit();
			} else {
				this.sceneToLoad = "MainMenu";
				Application.LoadLevel("Loading");
			}
		}
		                                     
	}

	void Awake() {
		Debug.Log ("ApplicationManager Awake()");
		DontDestroyOnLoad (transform.gameObject);
		ManageLocalization ();
	}

	//charge le dictionnaire de langue désiré
	public void ManageLocalization() {
		if (string.IsNullOrEmpty (PlayerPrefs.GetString("currentLanguage"))) {
			this.currentLanguage = (string.Compare (Application.systemLanguage.ToString(), "French", true) == 0) ? CultureMessage.CultureFile.FR : CultureMessage.CultureFile.US;
		} else {
			if(string.Compare(PlayerPrefs.GetString("currentLanguage"),CultureMessage.CultureFile.US.ToString(),true) == 0) {
				this.currentLanguage = CultureMessage.CultureFile.US;
			} else {
				this.currentLanguage = CultureMessage.CultureFile.FR;
			}
		}

		this.localMessage = new CultureMessage();
		this.localMessage.LoadMessages(this.currentLanguage);
	}
	#endregion
}
