using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class saveLevelChapter : MonoBehaviour {

	public void saveChapterLevel(int chapter)
	{
		PlayerPrefs.SetInt ("level", chapter);
	}
}
