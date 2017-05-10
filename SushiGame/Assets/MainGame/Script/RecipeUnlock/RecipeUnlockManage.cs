using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUnlockManage : MonoBehaviour {

    public GameObject Sushi6Text;
    public GameObject Sushi7Text;
    public GameObject Sushi8Text;
    public GameObject Sushi9Text;
    public GameObject Sushi10Text;

    public GameObject Black;

    private Text Sushi6TextSet;
    private Text Sushi7TextSet;
    private Text Sushi8TextSet;
    private Text Sushi9TextSet;
    private Text Sushi10TextSet;

    private static string SushiUnlock6 = "Cost "+ GameData.Sushi6.ToString();
    private static string SushiUnlock7 = "Cost " + GameData.Sushi7.ToString();
    private static string SushiUnlock8 = "Cost " + GameData.Sushi8.ToString();
    private static string SushiUnlock9 = "Cost " + GameData.Sushi9.ToString();
    private static string SushiUnlock10 = "Cost " + GameData.Sushi10.ToString();

    public GameObject SetUnlockSeal;

    public GameObject Setcount2;
    private Text Setcount2text;
    private static int Setcount2Num;

    public GameObject PopUpRecipe;
    public GameObject RecipeHeadText;
    public GameObject RecipeCostText;

	public AudioSource _myAudio;
	public AudioClip _myClipSushi;

    private Text RecipeHeadTextSet;
    private Text RecipeCostTextSet;

    private int RecipeSelect;

    private bool RecipePopUpShow = false;
    
    void Start () {

		_myAudio = GetComponent<AudioSource> ();

        Sushi6TextSet = Sushi6Text.GetComponent<Text>();
        Sushi7TextSet = Sushi7Text.GetComponent<Text>();
        Sushi8TextSet = Sushi8Text.GetComponent<Text>();
        Sushi9TextSet = Sushi9Text.GetComponent<Text>();
        Sushi10TextSet = Sushi10Text.GetComponent<Text>();

        Setcount2text = Setcount2.GetComponent<Text>();

        RecipeHeadTextSet = RecipeHeadText.GetComponent<Text>();
        RecipeCostTextSet = RecipeCostText.GetComponent<Text>();


    }
	
	
	void Update () {

        Sushi6TextSet.text = SushiUnlock6;
        Sushi7TextSet.text = SushiUnlock7;
        Sushi8TextSet.text = SushiUnlock8;
        Sushi9TextSet.text = SushiUnlock9;
        Sushi10TextSet.text = SushiUnlock10;

        Setcount2text.text = Setcount2Num.ToString() + "/5";

        if (PlayerStatus.Sushi6Unlock == true && PlayerStatus.Sushi7Unlock == true && PlayerStatus.Sushi8Unlock == true && PlayerStatus.Sushi9Unlock == true && PlayerStatus.Sushi10Unlock == true)
        {
            PlayerStatus.SushiSet2Unlock = true;
            SetUnlockSeal.SetActive(true);
            Setcount2.SetActive(false);

        }

    }

    public void Sushi6Unlock()
    {
        if (PlayerStatus.Sushi6Unlock == false)
        {
			_myAudio.Play ();
            RecipeSelect = 1;
            RecipeHeadTextSet.text = "Do yo want to Unlock Sushi6 Recipe";
            RecipeCostTextSet.text = SushiUnlock6;
            Black.SetActive(true);
            PopUpRecipe.SetActive(true);
            RecipePopUpShow = true;
        }
    }

    public void Sushi7Unlock()
    {
        if (PlayerStatus.Sushi7Unlock == false)
        {
			_myAudio.Play ();
            RecipeSelect = 2;
            RecipeHeadTextSet.text = "Do yo want to Unlock Sushi7 Recipe";
            RecipeCostTextSet.text = SushiUnlock7;
            Black.SetActive(true);
            PopUpRecipe.SetActive(true);
        }
    }

    public void Sushi8Unlock()
    {
        if (PlayerStatus.Sushi8Unlock == false)
        {
			_myAudio.Play ();
            RecipeSelect = 3;
            RecipeHeadTextSet.text = "Do yo want to Unlock Sushi8 Recipe";
            RecipeCostTextSet.text = SushiUnlock8;
            Black.SetActive(true);
            PopUpRecipe.SetActive(true);
            RecipePopUpShow = true;
        }
    }

    public void Sushi9Unlock()
    {
        if (PlayerStatus.Sushi9Unlock == false)
        {
			_myAudio.Play ();
            RecipeSelect = 4;
            RecipeHeadTextSet.text = "Do yo want to Unlock Sushi9 Recipe";
            RecipeCostTextSet.text = SushiUnlock9;
            Black.SetActive(true);
            PopUpRecipe.SetActive(true);
            RecipePopUpShow = true;
        }
    }

    public void Sushi10Unlock()
    {
        if (PlayerStatus.Sushi10Unlock == false)
        {
			_myAudio.Play ();
            RecipeSelect = 5;
            RecipeHeadTextSet.text = "Do yo want to Unlock Sushi10 Recipe";
            RecipeCostTextSet.text = SushiUnlock10;
            Black.SetActive(true);
            PopUpRecipe.SetActive(true);
            RecipePopUpShow = true;
        }
    }


    public void RecipeConfirmClick()
    {

        if (RecipeSelect == 1)
        {
            if (PlayerStatus.Sushi6Unlock == false)
            {
                if (PlayerStatus.Money >= GameData.Sushi6)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.Sushi6;
                    PlayerStatus.Sushi6Unlock = true;
                    SushiUnlock6 = "Unlock";
                    Setcount2Num++;
                    Black.SetActive(false);
                    PopUpRecipe.SetActive(false);
                    RecipePopUpShow = false;
					Sushi6Text.SetActive (true);

                }
            }
        }

        if (RecipeSelect == 2)
        {
            if (PlayerStatus.Sushi7Unlock == false)
            {
                if (PlayerStatus.Money >= GameData.Sushi7)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.Sushi7;
                    PlayerStatus.Sushi7Unlock = true;
                    SushiUnlock7 = "Unlock";
                    Setcount2Num++;
                    Black.SetActive(false);
                    PopUpRecipe.SetActive(false);
                    RecipePopUpShow = false;
					Sushi7Text.SetActive (true);
                }
            }
        }

        if (RecipeSelect == 3)
        {
            if (PlayerStatus.Sushi8Unlock == false)
            {
                if (PlayerStatus.Money >= GameData.Sushi8)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.Sushi8;
                    PlayerStatus.Sushi8Unlock = true;
                    SushiUnlock8 = "Unlock";
                    Setcount2Num++;
                    Black.SetActive(false);
                    PopUpRecipe.SetActive(false);
                    RecipePopUpShow = false;
					Sushi8Text.SetActive (true);
                }
            }
        }


        if (RecipeSelect == 4)
        {
            if (PlayerStatus.Sushi9Unlock == false)
            {
                if (PlayerStatus.Money >= GameData.Sushi9)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.Sushi9;
                    PlayerStatus.Sushi9Unlock = true;
                    SushiUnlock9 = "Unlock";
                    Setcount2Num++;
                    Black.SetActive(false);
                    PopUpRecipe.SetActive(false);
                    RecipePopUpShow = false;
					Sushi9Text.SetActive (true);
                }
            }
        }


        if (RecipeSelect == 5)
        {
            if (PlayerStatus.Sushi10Unlock == false)
            {
                if (PlayerStatus.Money >= GameData.Sushi10)
                {
					_myAudio.Play ();
                    PlayerStatus.Money -= GameData.Sushi10;
                    PlayerStatus.Sushi10Unlock = true;
                    SushiUnlock10 = "Unlock";
                    Setcount2Num++;
                    Black.SetActive(false);
                    PopUpRecipe.SetActive(false);
                    RecipePopUpShow = false;
					Sushi10Text.SetActive (true);
                }
            }
        }

        Save.SaveData();
    }

    public void RecipeCancelClick()
    {
		_myAudio.Play ();
        Black.SetActive(false);
        PopUpRecipe.SetActive(false);
        RecipePopUpShow = false;
    }


}
