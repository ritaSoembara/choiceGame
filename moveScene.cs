using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveScene : MonoBehaviour {

	public void movescene(string sceneName)
	{
		PlayerPrefs.SetString("namaScene",Application.loadedLevelName);
		Application.LoadLevel(sceneName);
		continueGame.cek = 1;
		histori.klik = 1;
	}


}
