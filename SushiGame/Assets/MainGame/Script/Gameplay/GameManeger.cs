using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManeger : MonoBehaviour {

    public GameObject SatisfyTextObject;
    public GameObject incomeTextObject;
    Text SatisfyText;
    Text incomeText;

    public bool Nicecheck = true;

    public static bool Timepasue = false;

    private int Satisfy;
	private int _Satisfyup;

    public int income;
	private int myincome2;

    public static bool TimeUp = false;

	void Start () {

        SatisfyText = SatisfyTextObject.GetComponent<Text>();
        incomeText = incomeTextObject.GetComponent<Text>();

        incomeText.text = income.ToString();
        SatisfyText.text = Satisfy.ToString() + "/100";

		if(PlayerStatus.CookingQualityLV == 0){
			_Satisfyup = 1;
		}if(PlayerStatus.CookingQualityLV == 1){
			_Satisfyup = 2;
		}if(PlayerStatus.CookingQualityLV == 2){
			_Satisfyup = 3;
		}if(PlayerStatus.CookingQualityLV == 3){
			_Satisfyup = 4;
		}if(PlayerStatus.CookingQualityLV == 4){
			_Satisfyup = 5;
		}
        
    }
	
	void Update () {

        if(TimeUp == true)
        {
            SentIncome();
            Save.SaveData();
            SceneManager.LoadScene("MainRestaurantManage");
        }

        if (Timepasue == true)
        {
            timepause();
            Timepasue = false;
        }

        if(Input.GetKeyDown("s"))
        {
            SatisfyGetOrLoss();
        }
		

        if(Input.GetKeyDown("n"))
        {
            if(Nicecheck == true)
            {
                Nicecheck = false;
                Debug.Log("CustomerUpset");
            }
            else
            if(Nicecheck == false)
            {
                Nicecheck = true;
                Debug.Log("CustomerHappy");
            }
        }


        if(Input.GetKeyDown("g"))
        {
            CustomerIncome();
        }



	}

    public void timepause()
    {
        if (Timer.stop == true)
        {
            Timer.stop = false;
            Debug.Log("Timer Start");
        }
        else
            if (Timer.stop == false)
        {
            Timer.stop = true;
            Debug.Log("Timer Stop");
        }
    }


    public void SentIncome()
    {
        PlayerStatus.Money += income;
        income = 0;
        incomeText.text = income.ToString();
        Debug.Log("TakeIncome");
    }
		
    public void CustomerIncome()
    {
		if (MainHomeManager.SetSelect == 2) {
			myincome2 = 25;
		} else {
			myincome2 = 0;
		}
		income += myincome2 + 100;
        incomeText.text = income.ToString();
        Debug.Log("GetIncome");
    }

    public void SatisfyGetOrLoss()
    {
        if (Nicecheck == true)
        {
            if (Satisfy <= 99)
            {
				Satisfy += _Satisfyup + 5;
                Debug.Log("GetSatisfy");
            }
            else
            if (Satisfy >= 100)
            {
                Satisfy = 100;
                Debug.Log("MaxSatisfy");
            }
            SatisfyText.text = Satisfy.ToString()+"/100";
        }
        else
            if(Nicecheck == false)
        {
            if (Satisfy >= 1)
            {
                Satisfy -= 5;
                Debug.Log("LossSatisfy");
            }
            else
            if (Satisfy <= 0)
            {
                Satisfy = 0;
                Debug.Log("LessSatisfy");
            }
            SatisfyText.text = Satisfy.ToString()+"/100";
        }

    }
}
