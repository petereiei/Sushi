using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBar : MonoBehaviour {

    public GameObject MoneyText;
    Text MoneyTextShow;


    void Start () {
        MoneyTextShow = MoneyText.GetComponent<Text>();

        MoneyTextShow.text = PlayerStatus.Money.ToString();
    }

    private void Update()
    {
        MoneyTextShow.text = PlayerStatus.Money.ToString();
    }

}
