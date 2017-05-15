using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class CookUpgradeManage : MonoBehaviour {

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;


    public GameObject Black;
    public GameObject SkillTextCS;

    private Text SetTextCS;


    public GameObject SkillTextMT;

    private Text SetTextMT;


    public GameObject SkillTextCQ;

    private Text SetTextCQ;

    public GameObject PopUpUI;
    public GameObject HeadText;
    public GameObject EffectText;
    public GameObject CostText;

    private Text HeadTextSet;
    private Text EffectTextSet;
    private Text CostTextSet;

    private int SkillSelect;

    private bool PopUpShow = false;

	public AudioClip _myClipSushi;


    void Start () {
		
       SetTextCS = SkillTextCS.GetComponent<Text>();
       

       SetTextMT = SkillTextMT.GetComponent<Text>();
       

       SetTextCQ = SkillTextCQ.GetComponent<Text>();
       


        HeadTextSet = HeadText.GetComponent<Text>();
        EffectTextSet = EffectText.GetComponent<Text>();
        CostTextSet = CostText.GetComponent<Text>();

	}
	

	void Update () {

        SetTextCS.text = "CookingSpeed LV " + PlayerStatus.CookingSpeedLV;
       


        SetTextMT.text = "MultiTasking LV " + PlayerStatus.MultiCookingLV;
       


        SetTextCQ.text = "CookingQuality LV " + PlayerStatus.CookingQualityLV;
        

    }

    public void CookingSpeedBtn()
    {
        if (PopUpShow == false)
        {
            PopUpShow = true;
            SkillSelect = 1;
            Black.SetActive(true);
            PopUpUI.SetActive(true);

            HeadTextSet.text = "Do you want to upgrade Cooking Speed Skill?";

            EffectTextSet.text = "This skill decrease your cooking time";

            if (PlayerStatus.CookingSpeedLV == 0)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingSpeedLV1Cost;
            }
            if (PlayerStatus.CookingSpeedLV == 1)
            {

				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingSpeedLV2Cost;
            }
            if (PlayerStatus.CookingSpeedLV == 2)
            {
				
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingSpeedLV3Cost;
            }
            if (PlayerStatus.CookingSpeedLV == 3)
            {

				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingSpeedLV4Cost;
            }
            if (PlayerStatus.CookingSpeedLV == 4)
            {

				_myAudio.Play ();
                CostTextSet.text = "MaxLV";
            }
        }

        
    }

    public void MultiTaskingBtn()
    {
        if (PopUpShow == false)
        {
            PopUpShow = true;
            SkillSelect = 2;
            Black.SetActive(true);
            PopUpUI.SetActive(true);

            HeadTextSet.text = "Do you want to upgrade MultiTasking Skill?";

            EffectTextSet.text = "You can do more order in the same time";


            if (PlayerStatus.MultiCookingLV == 0)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.MultiTaskingLV1Cost;
            }
            if (PlayerStatus.MultiCookingLV == 1)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.MultiTaskingLV2Cost;
            }
            if (PlayerStatus.MultiCookingLV == 2)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.MultiTaskingLV3Cost;
            }
            if (PlayerStatus.MultiCookingLV == 3)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.MultiTaskingLV4Cost;
            }
            if (PlayerStatus.MultiCookingLV == 4)
            {
				_myAudio.Play ();
                CostTextSet.text = "MaxLV";
            }
        }
    }

    public void CookingQualityBtn()
    {
        if (PopUpShow == false)
        {
            PopUpShow = true;
            SkillSelect = 3;
            Black.SetActive(true);
            PopUpUI.SetActive(true);

            HeadTextSet.text = "Do you want to upgrade MultiTasking Skill?";

            EffectTextSet.text = "You will receive more satisfy from customer";

            if (PlayerStatus.CookingQualityLV == 0)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingQualityLV1Cost;
            }
            if (PlayerStatus.CookingQualityLV == 1)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingQualityLV2Cost;
            }
            if (PlayerStatus.CookingQualityLV == 2)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingQualityLV3Cost;
            }
            if (PlayerStatus.CookingQualityLV == 3)
            {
				_myAudio.Play ();
                CostTextSet.text = "Cost " + GameData.CookingQualityLV4Cost;
            }
            if (PlayerStatus.CookingQualityLV == 4)
            {
				_myAudio.Play ();
                CostTextSet.text = "MaxLV";
            }
        }
    }

    public void SkillPopUpConfirm()
    {
         
        if(SkillSelect == 1)
        {
            if (PlayerStatus.CookingSpeedLV == 0)
            {
                if (PlayerStatus.Money >= GameData.CookingSpeedLV1Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingSpeedLV1Cost;
                    PlayerStatus.CookingSpeedLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);

                }

            }
            else
         if (PlayerStatus.CookingSpeedLV == 1)
            {
                if (PlayerStatus.Money >= GameData.CookingSpeedLV2Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingSpeedLV2Cost;
                    PlayerStatus.CookingSpeedLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
         if (PlayerStatus.CookingSpeedLV == 2)
            {
                if (PlayerStatus.Money >= GameData.CookingSpeedLV3Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingSpeedLV3Cost;
                    PlayerStatus.CookingSpeedLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
         if (PlayerStatus.CookingSpeedLV == 3)
            {
                if (PlayerStatus.Money >= GameData.CookingSpeedLV4Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingSpeedLV4Cost;
                    PlayerStatus.CookingSpeedLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
         if (PlayerStatus.CookingSpeedLV == 4)
            {
				_myAudio.Play ();
                Debug.Log("MaxLV");
                PopUpShow = false;
                Black.SetActive(false);
                PopUpUI.SetActive(false);
            }
            

        }
        
       

        if(SkillSelect == 2)
        {
            if (PlayerStatus.MultiCookingLV == 0)
            {
                if (PlayerStatus.Money >= GameData.MultiTaskingLV1Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.MultiTaskingLV1Cost;
                    PlayerStatus.MultiCookingLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
        if (PlayerStatus.MultiCookingLV == 1)
            {
                if (PlayerStatus.Money >= GameData.MultiTaskingLV2Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.MultiTaskingLV2Cost;
                    PlayerStatus.MultiCookingLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
        if (PlayerStatus.MultiCookingLV == 2)
            {
                if (PlayerStatus.Money >= GameData.MultiTaskingLV3Cost)
                {
					_myAudio.Play ();		
                    PlayerStatus.Money -= GameData.MultiTaskingLV3Cost;
                    PlayerStatus.MultiCookingLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
        if (PlayerStatus.MultiCookingLV == 3)
            {
                if (PlayerStatus.Money >= GameData.MultiTaskingLV4Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.MultiTaskingLV4Cost;
                    PlayerStatus.MultiCookingLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
        if (PlayerStatus.MultiCookingLV == 4)
            {
				_myAudio.Play ();
                Debug.Log("MaxLV");
                PopUpShow = false;
                Black.SetActive(false);
                PopUpUI.SetActive(false);
            }
            
        }

        if(SkillSelect == 3)
        {
            if (PlayerStatus.CookingQualityLV == 0)
            {
                if (PlayerStatus.Money >= GameData.CookingQualityLV1Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingQualityLV1Cost;
                    PlayerStatus.CookingQualityLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
       if (PlayerStatus.CookingQualityLV == 1)
            {
                if (PlayerStatus.Money >= GameData.CookingQualityLV2Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingQualityLV2Cost;
                    PlayerStatus.CookingQualityLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
       if (PlayerStatus.CookingQualityLV == 2)
            {
                if (PlayerStatus.Money >= GameData.CookingQualityLV3Cost)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.CookingQualityLV3Cost;
                    PlayerStatus.CookingQualityLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
       if (PlayerStatus.CookingQualityLV == 3)
            {
                if (PlayerStatus.Money >= GameData.CookingQualityLV4Cost)
                {
					_myAudio.Play ();			
                    PlayerStatus.Money -= GameData.CookingQualityLV4Cost;
                    PlayerStatus.CookingQualityLV += 1;
                    PopUpShow = false;
                    Black.SetActive(false);
                    PopUpUI.SetActive(false);
                }

            }
            else
       if (PlayerStatus.CookingQualityLV == 4)
            {
				_myAudio.Play ();
                Debug.Log("MaxLV");
                PopUpShow = false;
                Black.SetActive(false);
                PopUpUI.SetActive(false);
            }
            
        }
        Save.SaveData();
    }

    public void skillPopUpCancel()
    {
		_myAudio.Play ();
        PopUpShow = false;
        Black.SetActive(false);
        PopUpUI.SetActive(false);
    }

}
