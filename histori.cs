using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class histori : MonoBehaviour {

	public GameObject menu_histori;
	public static int klik;


	void Start()
	{
		PlayerPrefs.GetInt ("klik");
		Debug.Log (klik);
		cekKlik ();
	}

	public void cekKlik()
	{
		if (klik == 0) 
		{
			menu_histori.SetActive (false);
		} 
		else if (klik == 1) 
		{
			menu_histori.SetActive (true);
		}
	}
}
