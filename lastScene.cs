using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastScene : MonoBehaviour {

	// untuk cek apakah sudah dichapter terakhir atau belum. jika sudah maka button continue bernilai flse dan akan hilang di main menu
	public void cek_terakhir () {
		continueGame.cek = 0;
		Debug.Log ("cek");
		
	}
	

}
