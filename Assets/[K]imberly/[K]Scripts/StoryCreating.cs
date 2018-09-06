using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class StoryCreating : MonoBehaviour
{
    [SerializeField]
    private GameObject chapterStoryCanvas;
    [SerializeField]
    private GameObject shortStoryCanvas;
    [SerializeField]
    private TMPro.TMP_Text erroeMessage;
    [SerializeField]
    private TMPro.TMP_Text genreDropDown;
    [SerializeField]
    private TMPro.TMP_InputField checkFeild;

    private bool chapterStory;
    private void Start()
    {
        erroeMessage.enabled = false;
        shortStoryCanvas.SetActive(false);
        chapterStoryCanvas.SetActive(false);
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
        if (checkFeild.text == "")
        {
            erroeMessage.enabled = true;
            erroeMessage.text = "Please enter a Title";
        }
        else if (Directory.Exists("Story_Creation\\Chapter_Stories\\" + genreDropDown.text + "\\"  + storytitle.text))
        {
            erroeMessage.enabled = true;
          
            erroeMessage.text = storytitle.text + " Already Exists";
            Debug.Log("ChapterSotry");
        }
        else if(Directory.Exists("Story_Creation\\Short_Stories\\" + genreDropDown.text + "\\" + storytitle.text))
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
      if(!chapterStory)
        {
            shortStoryCanvas.SetActive(true);
        }
      else
        {
            chapterStoryCanvas.SetActive(true);
        }
        

    }
}
