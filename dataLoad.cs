using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataLoad : MonoBehaviour {

	public string namaScene; 

	public void load(){
		Application.LoadLevel(PlayerPrefs.GetString("namaScene"));

	}
}
