using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushibarManage : MonoBehaviour {


    public GameObject Black;

    private bool BarBtnPopUpshow = false;

    public GameObject BarLv;
    private Text BarLvText;

    public GameObject BarPopUI;

	AudioSource _myAudio;
	public AudioClip _myClipSushi;

    void Start()
    {
		_myAudio = GetComponent<AudioSource> ();
        BarLvText = BarLv.GetComponent<Text>();
        BarLvText.text = "Lv " + PlayerStatus.SushibarSlotLV;
    }

    public void BarManageOnclick()
    {
		_myAudio.Play ();
        if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false )
        {
			
            Black.SetActive(true);
            BarPopUpUI.BarUIShow = true;
            BarPopUI.SetActive(true);
        }
            

    }

    void FixedUpdate()
    {
        BarLvText.text = "Lv " + PlayerStatus.SushibarSlotLV;
    }

}
