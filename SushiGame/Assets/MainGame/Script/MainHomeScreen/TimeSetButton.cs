using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TimeSetButton : MonoBehaviour {

    static public float time;

    GameObject MoneyTextObject;
    Text MoneyText;


    public void TaskOnClick1()
    {
        time = GameData.TimeChioce1;
        Debug.Log("Click");
        Timer.stop = false;
        GameManeger.TimeUp = false;
        Save.SaveData();
        SceneManager.LoadScene("OpenShop");
    }

    public void TaskOnClick2()
    {
        if (PlayerStatus.Money >= GameData.TimeChioce2Cost)
        {
            time = GameData.TimeChioce2;
            Debug.Log("Click");
            PlayerStatus.Money -= GameData.TimeChioce2Cost;
            Timer.stop = false;
            GameManeger.TimeUp = false;
            Save.SaveData();
            SceneManager.LoadScene("OpenShop");
        }
        else
        {
            Debug.Log("Not enough Money");
        }
        
    }

    public void TaskOnClick3()
    {
        if (PlayerStatus.Money >= GameData.TimeChioce3Cost)
        {
            time = GameData.TimeChioce3;
            Debug.Log("Click");
            PlayerStatus.Money -= GameData.TimeChioce3Cost;
            Timer.stop = false;
            GameManeger.TimeUp = false;
            Save.SaveData();
            SceneManager.LoadScene("OpenShop");
        }
        else
        {
            Debug.Log("Not enough Money");
        }

    }

    public void TaskOnClick4()
    {
        if (PlayerStatus.Money >= GameData.TimeChioce4Cost)
        {
            time = GameData.TimeChioce4;
            Debug.Log("Click");
            PlayerStatus.Money -= GameData.TimeChioce4Cost;
            Timer.stop = false;
            GameManeger.TimeUp = false;
            Save.SaveData();
            SceneManager.LoadScene("OpenShop");
        }
        else
        {
            Debug.Log("Not enough Money");
        }

    }

}
