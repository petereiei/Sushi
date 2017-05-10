using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TablePopUpUI : MonoBehaviour {

    public GameObject Black;
    public GameObject TablePriceText;
    private Text TablePriceTextSet;

    public GameObject TableBuyText;
    private Text TableBuyTextSet;
	private int _mycount;

    static public int TableNumber;

    public static bool TableUIShow = false;

	AudioSource _myAudio;
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
		if(_myConfirm == true){
			_myConfirmC -= Time.deltaTime;
		}
		if(_myConfirmC <= 0f){
			MyConfirmOnclick ();
		}
	}

    public void ConfirmOnclick()
    {
		
		MyConfirmOn ();
		_myConfirm = true;
    }

	public void MyConfirmOnclick(){
		
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
	}

	void myCancel(){
		TableUIShow = false;
		Black.SetActive(false);
		this.gameObject.SetActive(false);
		_myCancel = false;
		_myCancelf = 1f;
	}

    public void CancelOnclick()
    {
		MyConfirmOn ();
		_myCancel = true;
    }

	public void MyConfirmOn(){
		_myAudio.Play ();
	}

}
