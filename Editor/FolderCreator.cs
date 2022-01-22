using System.IO;
using UnityEditor;
using UnityEngine;
using static System.IO.Directory;
using static System.IO.Path;
using static UnityEngine.Application;
using static UnityEditor.AssetDatabase;

namespace SafaDedeakay.Editor
{
    public static class FolderCreator
    {
        [MenuItem("Tools/Setup/Create Default Folders")]
        public static void CreateDefaultFolders()
        {
            Dir("Project",
                "Scenes",
                "Prefabs",
                "Scripts",
                "Scriptable Objects",
                "Sounds",
                "Animations",
                "Fonts",
                "Sprites"
            );
            Refresh();
        }

        public static void Dir(string root, params string[] dirs)
        {
            string fullPath = Combine(dataPath, root);
            foreach (string dir in dirs) CreateDirectory(Combine(fullPath, dir));
            
        }

    }
}
