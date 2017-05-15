using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatConsole : MonoBehaviour {

	[SerializeField]
	LuviConsole Console;

	void Start()
	{
		Console.AddCommand ("Add Money", "Will add money for specific amount", "addmoney", 1, CommandAddMoney);
	}

	void CommandAddMoney(string[] value)
	{
		int amount = 0;
		if (int.TryParse(value [1], out amount))
		{
			if (amount > 0) {
				PlayerStatus.Money += amount;
				LuviConsole.Log (amount + " added.", italic: true);
			}
			else
				LuviConsole.LogError ("cannot add money. paramters should be more than 1");
		}
	}
}
