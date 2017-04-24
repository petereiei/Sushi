using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour {

	public void BackToHomeOnclick()
    {
        TablePopUpUI.TableUIShow = false;
        BarPopUpUI.BarUIShow = false;
       
        Save.SaveData();

        SceneManager.LoadScene("MainRestaurantManage");
    }
}
