using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using UnityEditor;
using UnityEngine;

public static class SaveUtils
{
    private const string FileName = "gameSave.json";
    
    [MenuItem("Utils/Player save/Delete save")]
    private static void DeleteJsonSaveFile()
    {
        if (File.Exists(Path.Combine(Application.persistentDataPath, FileName)))
            File.Delete(Path.Combine(Application.persistentDataPath, FileName));
    }
}
