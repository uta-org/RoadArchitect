﻿using UnityEngine;


namespace RoadArchitect
{
    public class EditorUtilities : MonoBehaviour
    {


        /// <summary> Loads the _texture from _path if necessary </summary>
        public static void CheckLoadTexture<T>(ref T _texture, string _path) where T : Texture
        {
            if (_texture == null)
            {
                _texture = (T)UnityEditor.AssetDatabase.LoadAssetAtPath(_path, typeof(T)) as T;
            }
        }


        public static void DrawLine()
        {
            //Horizontal bar
            GUILayout.Space(4f);
            GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(1));
        }


        public static void Line(float _spacing = 4f, float _size = 1f)
        {
            //Horizontal bar
            GUILayout.Space(_spacing);
            GUILayout.Box("", GUILayout.ExpandWidth(true), GUILayout.Height(_size));
            GUILayout.Space(_spacing);
        }
    }
}