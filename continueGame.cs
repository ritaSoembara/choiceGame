using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continueGame : MonoBehaviour {

	public static int cek;
	public GameObject menu_cont;

	void Start()
	{
		PlayerPrefs.GetInt ("cek");
		Debug.Log (cek);
		cekMain ();
	}

	public void cekMain ()
	{
		if (cek == 0) 
		{
			menu_cont.SetActive (false);
		}
		else if (cek == 1 )
		{
			menu_cont.SetActive (true);
		}
	}


}
