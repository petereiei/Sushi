using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class BarPopUpUI : MonoBehaviour {

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _bgm;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;
    public GameObject Black;
    public GameObject ConfirmBtn;

    public GameObject BarText;
    private Text BarTextSet;
    public GameObject BarPriceText;
    private Text BarPriceTextSet;

    public static bool BarUIShow = false;

    private int NowLv = 0;
    private int NextLv = 0;
    private int NowCost;

	public AudioClip _myClipSushi;

	private void Start()
    {
        BarTextSet = BarText.GetComponent<Text>();
        BarPriceTextSet = BarPriceText.GetComponent<Text>();
    }

   private void Update()
    {


        if (PlayerStatus.SushibarSlotLV <= 4)
        {
            NowLv = PlayerStatus.SushibarSlotLV;
            NextLv = NowLv + 1;
            BarTextSet.text = "Do you want to Upgrade Sushibar from Lv " + NowLv.ToString() + " -> Lv " + NextLv.ToString();
            
            if(NowLv == 1 )
            {
                NowCost = GameData.sushibarLV2Cost;
            }
            if (NowLv == 2)
            {
                NowCost = GameData.sushibarLV3Cost;
            }
            if (NowLv == 3)
            {
                NowCost = GameData.sushibarLV4Cost;
            }
            if (NowLv == 4)
            {
                NowCost = GameData.sushibarLV5Cost;
            }

            BarPriceTextSet.text = "SushiBar Upgrade Cost : " + NowCost.ToString();



        }
        else
        if(PlayerStatus.SushibarSlotLV == 5)
        {
            ConfirmBtn.SetActive(false);
            BarPriceText.SetActive(false);
            BarTextSet.text = "You have Max SushibarSlot";
        }

    }

	public IEnumerator myConfirmOnclick(){

		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClipSushi);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		if(PlayerStatus.Money >= NowCost)
		{
			_myAudio.PlayOneShot (_myClipSushi);
			PlayerStatus.SushibarSlotLV += 1;
			PlayerStatus.Money -= NowCost;
			NowLv = 0;
			NextLv = 0;
			BarUIShow = false;
			Save.SaveData();
			Black.SetActive(false);
			this.gameObject.SetActive(false);

		}
		else
		{
			BarPriceTextSet.text = "Not enough money";
		}
		buttonOnclick[1].interactable = true;
		buttonOnclick [0].interactable = true;
	}

    public void ConfirmOnclick()
    {
		buttonOnclick[1].interactable = false;
		buttonOnclick [0].interactable = false;
		StartCoroutine (myConfirmOnclick ());

    }

	public IEnumerator myCancelOnclick(){
		float lerp = 0;
		float _time = 1f;
		_myAudio.PlayOneShot (_myClipSushi);
		while (_time > 0) {

			lerp = _time / 1f;
			_bgmGroup.audioMixer.SetFloat ("BGMVolume", Mathf.Lerp(-80.0f, 0.0f, lerp));
			yield return null;
			_time -= Time.deltaTime;
		}
		yield return null;
		NowLv = 0;
		NextLv = 0;
		BarUIShow = false;
		Black.SetActive(false);
		this.gameObject.SetActive(false);
		buttonOnclick[1].interactable = true;
		buttonOnclick [0].interactable = true;
	

	}

    public void CancelOnclick()
    {
		buttonOnclick[1].interactable = false;
		buttonOnclick [0].interactable = false;
		StartCoroutine (myCancelOnclick ());
   }
		
}
