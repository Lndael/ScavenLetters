using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class TextConverter : MonoBehaviour
{
    // Start is called before the first frame update

    public CharList List;
    public GameObject placeholder;
    public GameObject letterBlank;
    void Start()
    {
        fill();
    }

    // Update is called once per frame
    void fill()
    {
        for (int i = 0; i < List.Chars.Count; i++)
        {
            var letter = Instantiate(placeholder,letterBlank.transform);
            letter.GetComponent<Image>().sprite = List.Chars[i].Rune;
        }
    }
}
