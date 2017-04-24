using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SushibarManage : MonoBehaviour {


    public GameObject Black;

    private bool BarBtnPopUpshow = false;

    public GameObject BarLv;
    private Text BarLvText;

    public GameObject BarPopUI;

    void Start()
    {
        BarLvText = BarLv.GetComponent<Text>();
        BarLvText.text = "Lv " + PlayerStatus.SushibarSlotLV;
    }

    public void BarManageOnclick()
    {
        if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false )
        {
            Black.SetActive(true);
            BarPopUpUI.BarUIShow = true;
            BarPopUI.SetActive(true);
        }
            

    }

    void FixedUpdate()
    {
        BarLvText.text = "Lv " + PlayerStatus.SushibarSlotLV;
    }

}
