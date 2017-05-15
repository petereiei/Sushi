using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class TablePopUpUI : MonoBehaviour {

	[SerializeField]
	AudioMixerGroup _bgmGroup;

	[SerializeField]
	AudioSource _bgm;

	[SerializeField]
	AudioSource _myAudio;

	[SerializeField]
	Button[] buttonOnclick;

    public GameObject Black;
    public GameObject TablePriceText;
    private Text TablePriceTextSet;

    public GameObject TableBuyText;
    private Text TableBuyTextSet;
	private int _mycount;

    static public int TableNumber;

    public static bool TableUIShow = false;

	public AudioClip _myClipSushi;
	private bool _myCancel = false;
	private float _myCancelf = 1f;

	private bool _myConfirm = false;
	private float _myConfirmC = 1f;

    private void Start()
    {
			_myAudio = GetComponent<AudioSource> ();
            TableBuyTextSet = TableBuyText.GetComponent<Text>();
            TablePriceTextSet = TablePriceText.GetComponent<Text>();
            TableBuyTextSet.text = "Do you want to buy new TableSet?";
            TablePriceTextSet.text = "Table Cost " + GameData.TableCost.ToString();
    }

	void Update(){
		if(_myCancel == true){
			_myCancelf -= Time.deltaTime;
		}
		if(_myCancelf <= 0f){
			myCancel ();
		}
	}

    public void ConfirmOnclick()
    {
		buttonOnclick[1].interactable = false;
		buttonOnclick [0].interactable = false;
		StartCoroutine (MyConfirmOnclick ());
    }

	public IEnumerator MyConfirmOnclick(){
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
		if(PlayerStatus.Money >= GameData.TableCost)
		{
			if (TableNumber == 0)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table1Buy = true;
				PlayerStatus.Table1On = true;
				TableNumber = 1;
			}
			else if (TableNumber == 1)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table2Buy = true;
				PlayerStatus.Table2On = true;
				TableNumber = 2;
			}
			else if (TableNumber == 2)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table3Buy = true;
				PlayerStatus.Table3On = true;
				TableNumber = 3;
			}
			else if (TableNumber == 3)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table4Buy = true;
				PlayerStatus.Table4On = true;
				TableNumber = 4;
			}
			else if (TableNumber == 4)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table5Buy = true;
				PlayerStatus.Table5On = true;
				TableNumber = 5;
			}

			else if (TableNumber == 5)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table6Buy = true;
				PlayerStatus.Table6On = true;
				TableNumber = 6;
			}
			else if (TableNumber == 6)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table7Buy = true;
				PlayerStatus.Table7On = true;
				TableNumber = 7;
			}
			else if (TableNumber == 7)
			{
				PlayerStatus.Money -= GameData.TableCost;
				PlayerStatus.Table8Buy = true;
				PlayerStatus.Table8On = true;
				TableNumber = 8;
			}
			Save.SaveData();
			TableUIShow = false;
			Black.SetActive(false);
			this.gameObject.SetActive(false);
			_myConfirm = false;
			_myConfirmC = 1f;
		}
		else
		{
			//TablePriceTextSet.text = "Not enough Money";
		}

		buttonOnclick[1].interactable = true;
		buttonOnclick [0].interactable = true;
	}

	void myCancel(){
		TableUIShow = false;
		Black.SetActive(false);
		this.gameObject.SetActive(false);
		_myCancel = false;
		_myCancelf = 1f;
		buttonOnclick[1].interactable = true;
		buttonOnclick [0].interactable = true;
	}

    public void CancelOnclick()
    {
		buttonOnclick[1].interactable = false;
		buttonOnclick [0].interactable = false;
		_myAudio.PlayOneShot (_myClipSushi);
		_myCancel = true;
    }

	public void MyConfirmOn(){
		_myAudio.Play ();
	}

}
