using BepInEx;
using BepInEx.Logging;
using System.IO;
using System.Reflection;
using System.Linq;
using UnityEngine;

namespace Uranium;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger { get; private set; } = null!;

    private AssetBundle bundle;
    private GameObject prefab;
    
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        gameObject.hideFlags = HideFlags.DontSaveInEditor;

        Assembly assembly = Assembly.GetExecutingAssembly();
        using (Stream stream = assembly.GetManifestResourceStream("Uranium.Assets.jussis.bundle"))
            bundle = AssetBundle.LoadFromStream(stream);
        
        prefab = bundle.LoadAsset<GameObject>("jussis");
    }

    private void Update()
    {
        Uranium();
    }

    private void Uranium()
    {
        Instantiate(prefab);
        
        Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "jussis(Clone)/GameObject (20)/GameObject (20)/GameObject (20)");
        Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "jussis(Clone)/GameObject (20)/GameObject (20)/GameObject (20)");
        Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "jussis(Clone)/GameObject (20)/GameObject (20)/GameObject (20)");
        Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "jussis(Clone)/GameObject (20)/GameObject (20)/GameObject (20)");
        Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "jussis(Clone)/GameObject (20)/GameObject (20)/GameObject (20)");
        Resources.FindObjectsOfTypeAll<GameObject>().Where(obj => obj.name == "jussis(Clone)/GameObject (20)/GameObject (20)/GameObject (20)");
    }
}