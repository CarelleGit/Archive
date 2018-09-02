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
    [SerializeField]
    Toggle ChapterToggle;
    [SerializeField]
    Toggle shortToggle;

    private bool chapterStory;
    private void Start()
    {
        erroeMessage.enabled = false;
        ChapterToggle.isOn = false;
    }

    public void ChapterStoryToggle()
    {
       
        chapterStory = true;
    }

    public void ShortStoryToggle()
    {
      
        chapterStory = false;
    }

    public void CreateStory(TMPro.TMP_InputField storytitle)
    {
        if (Directory.Exists("Story_Creation\\Chapter_Stories\\" + genreDropDown.text + "\\"  + storytitle.text) && chapterStory == true)
        {
            erroeMessage.enabled = true;
            erroeMessage.text = storytitle.text + " Already Exists";
            Debug.Log("ChapterSotry");
        }
        else if(Directory.Exists("Story_Creation\\Short_Stories\\" + genreDropDown.text + "\\" + storytitle.text) && chapterStory == false)
        {
            erroeMessage.enabled = true;
            erroeMessage.text = storytitle.text + " Already Exists";
            Debug.Log("ShortSotry");
        }
        else
        {
            erroeMessage.enabled = false;
            if (chapterStory)
            {
                Directory.CreateDirectory("Story_Creation\\Chapter_Stories\\" + genreDropDown.text + "\\" + storytitle.text);
            }
            else
            {
                Directory.CreateDirectory("Story_Creation\\Short_Stories\\" + genreDropDown.text + "\\" + storytitle.text);
            }
        }
       

    }
}
