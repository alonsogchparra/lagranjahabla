using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour {

	public Sprite [] spriteDraw, spriteSpa, spriteEng;
	public Image imageDraw;
	public Button btnDraw, btnSpa, btnEng;
	public AudioSource audiSrc;
	public AudioClip[] audioClip, audioClipSpa, audioClipEng;

	private int i = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
  
    btnDraw.GetComponent<Image>().sprite = spriteDraw[i];
		btnSpa.GetComponent<Image>().sprite = spriteSpa[i];
    btnEng.GetComponent<Image>().sprite = spriteEng[i];

		if (audiSrc.isPlaying) {
			
			btnDraw.interactable = false;
			btnSpa.interactable = false;
			btnEng.interactable = false; 

		} else {
			
			btnDraw.interactable = true;
			btnSpa.interactable = true;
			btnEng.interactable = true; 

		}
		
	}

	public void NextButton () {

		if (i < spriteDraw.Length) {
			i++;

		}

		if (i == spriteDraw.Length) {
			i = 0;
		}

	}

	public void PreviousButton () {

		if (i > 0) {
			i--;
		}

		if (i == 0) {
			i = spriteDraw.Length - 1;
		}
	}

	public void AnimalSound () {
		audiSrc.PlayOneShot(audioClip[i]);
	}

	public void SpanishSound () {
		audiSrc.PlayOneShot(audioClipSpa[i]);
	}

	public void EnglishSound () {
		audiSrc.PlayOneShot(audioClipEng[i]);
	}

}
