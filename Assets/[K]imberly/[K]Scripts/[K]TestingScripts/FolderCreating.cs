using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class PlayerInfo
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Race { get; set; }
}

public class FolderCreating : MonoBehaviour
{
    string playerInfoSaving;
    // Use this for initialization
    void Start()
    {
        var folder = Directory.CreateDirectory("Dar");
        Debug.Log(Directory.GetDirectories("Dar"));
    }

    // Update is called once per frame
    void Update()
    {

        PlayerInfo player = new PlayerInfo()
        {

            Name = "No",
            Age = 4,
            Race = "Fuck you"
        };

        if (Input.GetKey(KeyCode.A))
        {
            playerInfoSaving = JsonConvert.SerializeObject(player, Formatting.Indented);
            using (StreamWriter sw = File.CreateText("Dar/testingDar.json"))
            {
                sw.Write(playerInfoSaving);
            }
        }
    }
}
