using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroManager: MonoBehaviour {
	public Text display;
	public int delay;
	public int textCount;

	void Start(){
		StartCoroutine(DisplayText());
	}

	IEnumerator DisplayText(){
		while (true) {
			switch (textCount) {
			case 0:
				display.text = "After centuries of rotting away up on Mount Killamantomorrow...";
				break;
			case 1:
				display.text = "...Tibia Shinsplint decided that he was no longer happy with his...";
				break;
			case 2:
				display.text = "skeleton life, and wanted to restore his humanity.";
				break;
			case 3:
				display.text = "Tibia would have to decend into the depths of hell...";
				break;
			case 4:
				display.text = "...and fight his way through the great skeleton lords...";
				break;
			case 5:
				display.text = "...to return to his human form.";
				break;
			case 6:
				display.text = "Thus begins his adventure.";
				break;
			default:
				yield return new WaitForSeconds (10);
				display.text = "You should really jump into the pit and begin your journey..";
				break;
			}
			textCount++;
			yield return new WaitForSeconds (delay);
		}
	}

	void OnTriggerEnter(Collider ChangeScene)
	{
		if(ChangeScene.gameObject.CompareTag("Player"))
		{
			Application.LoadLevelAdditive(1); 
		}
	}
}
