// Copyright (c) Unity Technologies.
// Based on the "URP TutorialInfo ReadmeEditor.cs" script included in URP template projects.
//
// Original asset by Unity Technologies. This version has been modified to display
// a custom Readme.asset in the Inspector about how to use the Singletons package
//
// Modified by ThatAmuzak - 2025

using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Readme", menuName = "ScriptableObjects/Readme", order = 1)]
public class Readme : ScriptableObject
{
    public string title;
    public Section[] sections;

    [Serializable]
    public class Section
    {
        public string heading;
        public List<string> text;
    }
}
