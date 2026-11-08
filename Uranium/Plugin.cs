using BepInEx;
using BepInEx.Logging;
using System.Collections.Generic;
using UnityEngine;

namespace Uranium;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger { get; private set; } = null!;
    
    private float timer;
    private int loopAmount;
    private int mainLoopAmount;
    private List<List<string>> mainList = new();
    private List<string> subList = new();
    
    private void Awake()
    {
        // Plugin startup logic
        Logger = base.Logger;
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        gameObject.hideFlags = HideFlags.DontSaveInEditor;
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            loopAmount++;
            timer = 0f;
        }

        if (loopAmount >= mainLoopAmount)
        {
            mainLoopAmount++;
        }
        Uranium();
    }

    private void Uranium()
    {
        for (int i = 0; i < loopAmount; i++)
        {
            subList.Add($"Entry {i}");
        }

        for (int i = 0; i < mainLoopAmount; i++)
        {
            mainList.Add(new List<string>(subList));
        }
        
        subList.Clear();
        mainList.Clear();
    }
}