using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text nameText;
    public InputField nameInput;
    public RawImage image;
    public Texture cat;
    public Texture dog;

    public void ButtonPress()
    {
        if (nameInput.text == "cat")
        {
            nameText.text = "cat";
            image.texture = cat;
        }

        if(nameInput.text == "dog")
        {
            nameText.text = "dog";
            image.texture = dog;
        }
    }
}