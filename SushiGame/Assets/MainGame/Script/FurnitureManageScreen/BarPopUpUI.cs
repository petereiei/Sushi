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

    private void Start()
    {
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
    }

    public void ConfirmOnclick()
    {

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
            
        }
        else
        {
            BarPriceTextSet.text = "Not enough money";
        }

    }



    public void CancelOnclick()
    {

        NowLv = 0;
        NextLv = 0;
        BarUIShow = false;
        Black.SetActive(false);
        this.gameObject.SetActive(false);

   }


}
