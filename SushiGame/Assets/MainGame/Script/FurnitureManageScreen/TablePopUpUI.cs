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

    static public int TableNumber;

    public static bool TableUIShow = false;


    private void Start()
    {
            TableBuyTextSet = TableBuyText.GetComponent<Text>();
            TablePriceTextSet = TablePriceText.GetComponent<Text>();
            TableBuyTextSet.text = "Do you want to buy new TableSet?";
            TablePriceTextSet.text = "Table Cost " + GameData.TableCost.ToString();
    }

    public void ConfirmOnclick()
    {
        if(PlayerStatus.Money >= GameData.TableCost)
        {

            if (TableNumber == 1)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table1Buy = true;
                PlayerStatus.Table1On = true;

            }
            if (TableNumber == 2)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table2Buy = true;
                PlayerStatus.Table2On = true;

            }
            if (TableNumber == 3)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table3Buy = true;
                PlayerStatus.Table3On = true;
           
            }
            if (TableNumber == 4)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table4Buy = true;
                PlayerStatus.Table4On = true;
             
            }
            if (TableNumber == 5)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table5Buy = true;
                PlayerStatus.Table5On = true;
       
            }

            if (TableNumber == 6)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table6Buy = true;
                PlayerStatus.Table6On = true;
           
            }
            if (TableNumber == 7)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table7Buy = true;
                PlayerStatus.Table7On = true;
           
            }
            if (TableNumber == 8)
            {
                PlayerStatus.Money -= GameData.TableCost;
                PlayerStatus.Table8Buy = true;
                PlayerStatus.Table8On = true;
           
            }
            Save.SaveData();
            TableUIShow = false;
            Black.SetActive(false);
            this.gameObject.SetActive(false);
        }
       else
        {
            //TablePriceTextSet.text = "Not enough Money";
        }
    }



    public void CancelOnclick()
    {
        TableUIShow = false;
        Black.SetActive(false);
        this.gameObject.SetActive(false);
    }

}
