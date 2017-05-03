using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSetManage : MonoBehaviour {

    public GameObject Black;

    //TableSet
    public GameObject Table1;
    public GameObject Table1Off;
    public GameObject FreeSpace1;
    public GameObject Table2;
    public GameObject Table2Off;
    public GameObject FreeSpace2;
    public GameObject Table3;
    public GameObject Table3Off;
    public GameObject FreeSpace3;
    public GameObject Table4;
    public GameObject Table4Off;
    public GameObject FreeSpace4;
    public GameObject Table5;
    public GameObject Table5Off;
    public GameObject FreeSpace5;
    public GameObject Table6;
    public GameObject Table6Off;
    public GameObject FreeSpace6;
    public GameObject Table7;
    public GameObject Table7Off;
    public GameObject FreeSpace7;
    public GameObject Table8;
    public GameObject Table8Off;
    public GameObject FreeSpace8;

    private bool TableBuyBtn1Show = false;
    private bool TableBuyBtn2Show = false;
    private bool TableBuyBtn3Show = false;
    private bool TableBuyBtn4Show = false;
    private bool TableBuyBtn5Show = false;
    private bool TableBuyBtn6Show = false;
    private bool TableBuyBtn7Show = false;
    private bool TableBuyBtn8Show = false;

    public GameObject TableUI;

    private void FixedUpdate()
    {
        if(PlayerStatus.Table1Buy == true)
        {
            if(PlayerStatus.Table1On == true)
            {
                FreeSpace1.SetActive(false);
                Table1.SetActive(true);
                Table1Off.SetActive(false);
            }
            else
            if(PlayerStatus.Table1On == false)
            {
                FreeSpace1.SetActive(false);
                Table1.SetActive(false);
                Table1Off.SetActive(true);
            }

        }

        if (PlayerStatus.Table2Buy == true)
        {
            if (PlayerStatus.Table2On == true)
            {
                FreeSpace2.SetActive(false);
                Table2.SetActive(true);
                Table2Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table2On == false)
            {
                FreeSpace2.SetActive(false);
                Table2.SetActive(false);
                Table2Off.SetActive(true);
            }
        }

        if (PlayerStatus.Table3Buy == true)
        {
            if (PlayerStatus.Table3On == true)
            {
                FreeSpace3.SetActive(false);
                Table3.SetActive(true);
                Table3Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table3On == false)
            {
                FreeSpace3.SetActive(false);
                Table3.SetActive(false);
                Table3Off.SetActive(true);
            }
        }

        if (PlayerStatus.Table4Buy == true)
        {
            if (PlayerStatus.Table4On == true)
            {
                FreeSpace4.SetActive(false);
                Table4.SetActive(true);
                Table4Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table4On == false)
            {
                FreeSpace4.SetActive(false);
                Table4.SetActive(false);
                Table4Off.SetActive(true);
            }
        }

        if (PlayerStatus.Table5Buy == true)
        {
            if (PlayerStatus.Table5On == true)
            {
                FreeSpace5.SetActive(false);
                Table5.SetActive(true);
                Table5Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table5On == false)
            {
                FreeSpace5.SetActive(false);
                Table5.SetActive(false);
                Table5Off.SetActive(true);
            }
        }

        if (PlayerStatus.Table6Buy == true)
        {
            if (PlayerStatus.Table6On == true)
            {
                FreeSpace6.SetActive(false);
                Table6.SetActive(true);
                Table6Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table6On == false)
            {
                FreeSpace6.SetActive(false);
                Table6.SetActive(false);
                Table6Off.SetActive(true);
            }
        }

        if (PlayerStatus.Table7Buy == true)
        {
            if (PlayerStatus.Table7On == true)
            {
                FreeSpace7.SetActive(false);
                Table7.SetActive(true);
                Table7Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table7On == false)
            {
                FreeSpace7.SetActive(false);
                Table7.SetActive(false);
                Table7Off.SetActive(true);
            }
        }

        if (PlayerStatus.Table8Buy == true)
        {
            if (PlayerStatus.Table8On == true)
            {
                FreeSpace8.SetActive(false);
                Table8.SetActive(true);
                Table8Off.SetActive(false);
            }
            else
            if (PlayerStatus.Table8On == false)
            {
                FreeSpace8.SetActive(false);
                Table8.SetActive(false);
                Table8Off.SetActive(true);
            }
        }
    }



    public void Table1ManageOnclick()
    {
        if(TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 1;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table2ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 1)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 2;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table3ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 2)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 3;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table4ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 3)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 4;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table5ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 4)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 5;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table6ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 5)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 6;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table7ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 6)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 7;
            TablePopUpUI.TableUIShow = true;
        }
    }

    public void Table8ManageOnclick()
    {
		if (TablePopUpUI.TableUIShow == false && BarPopUpUI.BarUIShow == false && TablePopUpUI.TableNumber == 7)
        {
            Black.SetActive(true);
            TableUI.SetActive(true);
            TablePopUpUI.TableNumber = 8;
            TablePopUpUI.TableUIShow = true;
        }
    }

    
    public void Table1Onclick()
    {
        PlayerStatus.Table1On = true;
    }

    public void Table2Onclick()
    {
        PlayerStatus.Table2On = true;
    }

    public void Table3Onclick()
    {
        PlayerStatus.Table3On = true;
    }

    public void Table4Onclick()
    {
        PlayerStatus.Table4On = true;
    }

    public void Table5Onclick()
    {
        PlayerStatus.Table5On = true;
    }

    public void Table6Onclick()
    {
        PlayerStatus.Table6On = true;
    }

    public void Table7Onclick()
    {
        PlayerStatus.Table7On = true;
    }

    public void Table8Onclick()
    {
        PlayerStatus.Table8On = true;
    }


    public void Table1Offclick()
    {
        PlayerStatus.Table1On = false;
    }

    public void Table2Offclick()
    {

        PlayerStatus.Table2On = false;
    }

    public void Table3Offclick()
    {
        PlayerStatus.Table3On = false;
    }

    public void Table4Offclick()
    {
        PlayerStatus.Table4On = false;
    }

    public void Table5Offclick()
    {
        PlayerStatus.Table5On = false;
    }

    public void Table6Offclick()
    {
        PlayerStatus.Table6On = false;
    }

    public void Table7Offclick()
    {
        PlayerStatus.Table7On = false;
    }

    public void Table8Offclick()
    {
        PlayerStatus.Table8On = false;
    }

}