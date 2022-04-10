using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ASCIILevelLoader : MonoBehaviour
{
    public string fileName;
    public float xOffset;
    public float zOffset;
    
    
    // Start is called before the first frame update
    void Start()
    {
        LoadLevel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel()
    {
        StreamReader reader = new StreamReader(fileName); //opens a new stream reader based on given file name.
        string fileContent = reader.ReadToEnd();    //creates a string thats read from the entire file. 
        reader.Close(); //closes streamreader.

        char newLineChar = '\n'; //creates a character delimiter. 

        string[] level = fileContent.Split(newLineChar); //creates a level string that splits the file by the newline Delimiter. 

        for(int i = 0; i<level.Length; i++) //for loop that checks each entyr in level array and makes a row based on that parameter. 
        {
            MakeRow(level[i], -i);
        }
    }

    void MakeRow(string stringRow, float z) //builds level based on string row. 
    {
        char[] rowArray = stringRow.ToCharArray(); //creates character array and assigns characters based on the string row. 
        for(int x = 0; x < stringRow.Length; x++) //for loop that creates an object based on characters read in the row array. 
        {
            char c = rowArray[x];
            if(c == 'P')
            {
                GameObject PLATFORM = Instantiate(Resources.Load("Platform")) as GameObject;
                PLATFORM.transform.position = new Vector3(
                    x * PLATFORM.transform.localScale.x + xOffset,
                    1,
                    z * PLATFORM.transform.localScale.z + zOffset
                    );
            } else if(c == 'S')
            {
                GameObject SHORTPLAT = Instantiate(Resources.Load("ShortPlatform")) as GameObject;
                SHORTPLAT.transform.position = new Vector3(
                    x * SHORTPLAT.transform.localScale.x + xOffset,
                    1,
                    z * SHORTPLAT.transform.localScale.z + zOffset
                    );
            }else if(c == 'M')
            {
                GameObject MIDPLAT = Instantiate(Resources.Load("MidPlatform")) as GameObject;
                MIDPLAT.transform.position = new Vector3(
                    x * MIDPLAT.transform.localScale.x + xOffset,
                    1,
                    z * MIDPLAT.transform.localScale.z + zOffset
                    );
            }else if (c == 'T')
            {
                GameObject TALLPLAT = Instantiate(Resources.Load("TallPlatform")) as GameObject;
                TALLPLAT.transform.position = new Vector3(
                    x * TALLPLAT.transform.localScale.x + xOffset,
                    1,
                    z * TALLPLAT.transform.localScale.z + zOffset
                    );
            }else if (c == 'G')
            {
                GameObject GOAL = Instantiate(Resources.Load("Goal")) as GameObject;
                GOAL.transform.position = new Vector3(
                    x * GOAL.transform.localScale.x + xOffset,
                    1,
                    z * GOAL.transform.localScale.z + zOffset
                    );
            }
        }
    }
}
