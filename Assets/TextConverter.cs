using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class TextConverter : MonoBehaviour
{
    // Start is called before the first frame update

    public CharList List;
    public GameObject placeholder;
    public GameObject letterBlank;
    public String path;
    private string[] textArray;
    
    void Start()
    {
        path = "/Source.txt";
        textArray = File.ReadAllLines(path);
        fill();
    }

    // Update is called once per frame
    void fill()
    {
        for (int i = 0; i < textArray.Length; i++)
        {
            
            foreach (var VARIABLE in textArray[i].ToUpper())
            {
                var letter = Instantiate(placeholder,letterBlank.transform);
                
                //letter.GetComponent<Image>().sprite = ;
            }
            
        }
    }
}
