using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    public TextAsset file;
    Dictionary<string, string> data;
    public Text textUI;

    void Start()
    {
        data = new Dictionary<string, string>();
        var text = file.text;
        var arrText = text.Split('\n');
        foreach( var item in arrText)
        {
            var keyValue = item.Split(":");
            data.Add(keyValue[0], keyValue[1]);
        }
    }

    // Update is called once per frame
    public void ShowText(string key)
    {
        textUI.text = data[key];

    }
}
