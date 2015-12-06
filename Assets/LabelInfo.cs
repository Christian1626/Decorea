using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LabelInfo : MonoBehaviour {
	
	Text txt;
	private int currentscore=0;
	
	// Use this for initialization
	void Start () {
		txt = gameObject.GetComponent<Text>(); 
		txt.text="Score : " + currentscore;
	}

}