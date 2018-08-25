using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FolderCreation : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        if (!Directory.Exists("World_Building") && !Directory.Exists("Story_Creation"))
        {
            Directory.CreateDirectory("World_Building");
            Directory.CreateDirectory("Story_Creation");
        }
    }
}
