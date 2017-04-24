using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
public class Playerprefeditor {


    [MenuItem("Player Pref/Delete all player pref")]
    public static void Deleteallplayerpref()
    {
        PlayerPrefs.DeleteAll();
    }

}
