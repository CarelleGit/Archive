using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class StoryCreating : MonoBehaviour
{
    [SerializeField]
    TMPro.TMP_Text erroeMessage;
    [SerializeField]
    TMPro.TMP_Text genreDropDown;
    private void Start()
    {
        erroeMessage.enabled = false;
    }

    public void CreateStory(TMPro.TMP_InputField storytitle)
    {
        if (Directory.Exists("Story_Creation\\" + genreDropDown.text + "\\"  + storytitle.text))
        {
            erroeMessage.enabled = true;
            erroeMessage.text = storytitle.text + " Already Exists";
        }
        else
        {
            erroeMessage.enabled = false;
            Directory.CreateDirectory("Story_Creation\\" + genreDropDown.text + "\\" + storytitle.text);
        }

    }
}
