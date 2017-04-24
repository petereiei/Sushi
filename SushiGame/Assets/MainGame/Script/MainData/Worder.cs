using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Worder : MonoBehaviour {

    public GameObject worder;
    public InputField WordField;


	
    void FixedUpdate() {

          if(Input.GetKeyDown("w")&& Input.GetKeyDown("d"))
            {
                worder.SetActive(true);
            }

    }
	
    public void OnWordEnd()
    {
        
        if(WordField.text == "#whereismymoney")
        {
            PlayerStatus.Money += 99999;
        }
        if (WordField.text == "#nomore")
        {
            PlayerStatus.Money = 0;
        }

        worder.SetActive(false);
        WordField.text = "";
    }
	
}
