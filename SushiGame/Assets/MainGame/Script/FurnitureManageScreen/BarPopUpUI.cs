using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarPopUpUI : MonoBehaviour {

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

	AudioSource _myAudio;
	public AudioClip _myClipSushi;
	private bool _myCancel = false;
	private float _myCancelf = 1f;

	private bool _myConfirm = false;
	private float _myConfirmC = 1f;

	private void Start()
    {
		_myAudio = GetComponent<AudioSource> ();
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


		if(_myCancel == true){
			_myCancelf -= Time.deltaTime;
		}
		if(_myCancelf <= 0f){
			myCancelOnclick ();
		}if(_myConfirm == true){
			_myConfirmC -= Time.deltaTime;
		}
		if(_myConfirmC <= 0f){
			myConfirmOnclick ();
		}

    }

	public void myConfirmOnclick(){

		if(PlayerStatus.Money >= NowCost)
		{
			PlayerStatus.SushibarSlotLV += 1;
			PlayerStatus.Money -= NowCost;
			NowLv = 0;
			NextLv = 0;
			BarUIShow = false;
			Save.SaveData();
			Black.SetActive(false);
			this.gameObject.SetActive(false);
			_myConfirm = false;
			_myConfirmC = 1f;

		}
		else
		{
			BarPriceTextSet.text = "Not enough money";
		}
	}

    public void ConfirmOnclick()
    {
		MyConfirmOnclick ();
		_myConfirm = true;

    }

	public void myCancelOnclick(){
		NowLv = 0;
		NextLv = 0;
		BarUIShow = false;
		Black.SetActive(false);
		this.gameObject.SetActive(false);
		_myCancel = false;
		_myCancelf = 1f;
	}

    public void CancelOnclick()
    {
		_myAudio.PlayOneShot (_myClipSushi);
		_myCancel = true;
   }

	public void MyConfirmOnclick(){
		_myAudio.Play ();
	}
		
}
