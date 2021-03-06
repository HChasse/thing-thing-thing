﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Creature))]
public class CreatureEditor : Editor
{

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        Creature creature = (Creature)target;
        if (GUILayout.Button("Speak"))
        {
            creature.Speak("AHA!",2f);
        }

        if(GUILayout.Button("Spark"))
        {
            creature.Spark(Color.blue, 10);
        }


    }

}
