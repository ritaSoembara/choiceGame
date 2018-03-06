using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class levelLock : MonoBehaviour {


	[SerializeField] int levelRequire;
	public void Start()
	{
		int currenLevel = PlayerPrefs.GetInt ("level");
		bool levelUnlocked = currenLevel >= levelRequire;
		GetComponent<Button> ().interactable = levelUnlocked; 

	}

	public void ambil(string sceneName)
	{
		Application.LoadLevel(PlayerPrefs.GetString("sceneName"));
	}


}
