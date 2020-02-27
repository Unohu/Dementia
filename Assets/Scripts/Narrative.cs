using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "Narrative")]
public class Narrative : ScriptableObject
{
     public string id;
     public Color color = Color.white;
     [TextArea (minLines:7, maxLines: 7)]
     public string line;
     public string person;

     public string GetLine()
     {
          return person + ": " + line;

     }
}
