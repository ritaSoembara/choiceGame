using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class dataSimpan : MonoBehaviour {

	public static string namaScene;

	public void save()
	{
		PlayerPrefs.SetString("namaScene",Application.loadedLevelName);
	}
}
