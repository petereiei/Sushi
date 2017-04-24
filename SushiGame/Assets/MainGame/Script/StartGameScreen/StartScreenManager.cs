using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LitJson;

public class StartScreenManager : MonoBehaviour {

    public void GameStartOnClick()
    {

        SceneManager.LoadScene("MainRestaurantManage");
        Load.LoadData();

    }
   
	

}
