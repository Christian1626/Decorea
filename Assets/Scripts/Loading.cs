using UnityEngine;
using System.Collections;

public class Loading : MonoBehaviour {

	ApplicationManager applicationManager;
	AsyncOperation asynAction;
	float percentageLoaded;
	GUIText loadingText;

	IEnumerator Start() {
		this.applicationManager = GameObject.Find("ApplicationManager").GetComponent<ApplicationManager>();
		this.loadingText = GameObject.Find("LoadingText").GetComponent<GUIText>();
		percentageLoaded = 0;

		string labelValue=string.Empty;
		string loadingLabel = (applicationManager.LocalMessage.Messages.TryGetValue("Loading",out labelValue)) ? labelValue: string.Empty;
		this.loadingText.text = loadingLabel;

		AsyncOperation async = Application.LoadLevelAsync(applicationManager.SceneToLoad);
		yield return async;
	}
}
