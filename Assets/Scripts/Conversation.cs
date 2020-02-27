using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "Conversation")]

public class Conversation : ScriptableObject
{
    private int index = 0;
    public Narrative[] lines;

    public Narrative GetNextLine()
    {
        index++;
        
        if (index <= lines.Length)
        {
            return lines[index];
        }

        return lines[0];
    }
}
