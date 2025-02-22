// Copyright (c) Unity Technologies.
// Based on the "URP TutorialInfo ReadmeEditor.cs" script included in URP template projects.
//
// Original asset by Unity Technologies. This version has been modified to display
// a custom Readme.asset in the Inspector about how to use the Singletons package
//
// Modified by github.com/ThatAmuzak - 2025

using UnityEngine;
using UnityEditor;
using System.IO;

[CustomEditor(typeof(Readme))]
public class ReadmeEditor : Editor
{
    const float k_Space = 8f;

    static void RemoveTutorial()
    {
        string s_ReadmeSourcePath = GetReadmePath();
        if (string.IsNullOrEmpty(s_ReadmeSourcePath))
        {
            Debug.LogWarning("Could not determine the Readme folder path.");
            return;
        }

        string s_ReadmeSourceDirectory = Path.GetDirectoryName(s_ReadmeSourcePath) + "\\SamplesGuideInfo";

        if (EditorUtility.DisplayDialog("Remove Readme Assets", $"All contents under {s_ReadmeSourceDirectory} will be removed, are you sure you want to proceed?", "Proceed", "Cancel"))
        {
            if (Directory.Exists(s_ReadmeSourceDirectory))
            {
                FileUtil.DeleteFileOrDirectory(s_ReadmeSourceDirectory);
                FileUtil.DeleteFileOrDirectory(s_ReadmeSourceDirectory + ".meta");
            }
            else
            {
                Debug.Log($"Could not find the Readme folder at {s_ReadmeSourceDirectory}");
            }

            var readmeAsset = SelectReadme();
            if (readmeAsset != null)
            {
                var path = AssetDatabase.GetAssetPath(readmeAsset);
                FileUtil.DeleteFileOrDirectory(path + ".meta");
                FileUtil.DeleteFileOrDirectory(path);
            }

            AssetDatabase.Refresh();
        }
    }

    static string GetReadmePath()
    {
        var readmeAsset = Selection.activeObject;
        if (readmeAsset == null) return string.Empty;

        string path = AssetDatabase.GetAssetPath(readmeAsset);
        return path;
    }

    static Readme SelectReadme()
    {
        var ids = AssetDatabase.FindAssets("Readme t:Readme");
        if (ids.Length == 1)
        {
            var readmeObject = AssetDatabase.LoadMainAssetAtPath(AssetDatabase.GUIDToAssetPath(ids[0]));

            Selection.objects = new[] { readmeObject };

            return (Readme)readmeObject;
        }

        Debug.Log("Couldn't find a readme");
        return null;
    }

    protected override void OnHeaderGUI()
    {
        var readme = (Readme)target;
        Init();

        GUILayout.BeginHorizontal("In BigTitle");
        {
            GUILayout.Space(k_Space);
            GUILayout.BeginVertical();
            {

                GUILayout.FlexibleSpace();
                GUILayout.Label(readme.title, TitleStyle);
                GUILayout.FlexibleSpace();
            }
            GUILayout.EndVertical();
            GUILayout.FlexibleSpace();
        }
        GUILayout.EndHorizontal();
    }

    public override void OnInspectorGUI()
    {
        var readme = (Readme)target;
        Init();
        Rect rect;
        foreach (var section in readme.sections)
        {
            GUILayout.Space(k_Space);
            rect = EditorGUILayout.GetControlRect(false, 2 );
            rect.height = 2;
            EditorGUI.DrawRect(rect, new Color ( 0.5f,0.5f,0.5f, 1 ) );
            GUILayout.Space(k_Space);

            if (!string.IsNullOrEmpty(section.heading))
            {
                GUILayout.Label(section.heading, HeadingStyle);
            }

            foreach (var subtext in section.text)
            {
                if (!string.IsNullOrEmpty(subtext))
                {
                    GUILayout.Label(subtext, BodyStyle);
                }
            }
        }
        GUILayout.Space(k_Space);
        rect = EditorGUILayout.GetControlRect(false, 2 );
        rect.height = 2;
        GUILayout.Space(k_Space);
        if (GUILayout.Button("Remove Readme Assets", ButtonStyle))
        {
            RemoveTutorial();
        }
    }

    bool m_Initialized;

    GUIStyle TitleStyle => m_TitleStyle;

    [SerializeField]
    GUIStyle m_TitleStyle;

    GUIStyle HeadingStyle => m_HeadingStyle;

    [SerializeField]
    GUIStyle m_HeadingStyle;

    GUIStyle BodyStyle => m_BodyStyle;

    [SerializeField]
    GUIStyle m_BodyStyle;

    GUIStyle ButtonStyle => m_ButtonStyle;

    [SerializeField]
    GUIStyle m_ButtonStyle;

    void Init()
    {
        if (m_Initialized)
            return;
        m_BodyStyle = new GUIStyle(EditorStyles.label);
        m_BodyStyle.wordWrap = true;
        m_BodyStyle.fontSize = 14;
        m_BodyStyle.richText = true;

        m_TitleStyle = new GUIStyle(m_BodyStyle);
        m_TitleStyle.fontSize = 26;

        m_HeadingStyle = new GUIStyle(m_BodyStyle);
        m_HeadingStyle.fontStyle = FontStyle.Bold;
        m_HeadingStyle.fontSize = 18;

        m_ButtonStyle = new GUIStyle(EditorStyles.miniButton);
        m_ButtonStyle.fontStyle = FontStyle.Bold;

        m_Initialized = true;
    }
}
