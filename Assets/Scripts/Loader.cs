using UnityEngine;
using System.Collections;


public class Loader : MonoBehaviour {
	#region Fields
	[SerializeField]
	private float waitingTimeSecond;
	#endregion
	
	#region Methods
	void Start () {
		ApplicationManager applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		applicationManager.SceneToLoad = "MainMenu";
		StartCoroutine(WaitingFor());
	}

	private IEnumerator WaitingFor() {
		yield return new WaitForSeconds(waitingTimeSecond);
		Application.LoadLevel("Loading");
	}
	#endregion
}
