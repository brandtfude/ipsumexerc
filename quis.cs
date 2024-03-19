using System;
using System.Collections.Generic;

public class KeyChangeDetector
{
    private Dictionary<string, string> _originalConfig;
    private Dictionary<string, string> _currentConfig;

    public KeyChangeDetector(Dictionary<string, string> originalConfig)
    {
        _originalConfig = new Dictionary<string, string>(originalConfig);
        _currentConfig = new Dictionary<string, string>(originalConfig);
    }

    public void UpdateConfig(Dictionary<string, string> newConfig)
    {
        _currentConfig = new Dictionary<string, string>(newConfig);
    }

    public void DetectsChangedKeys()
    {
        foreach (var key in _originalConfig.Keys)
        {
            if (_currentConfig.ContainsKey(key))
            {
                if (_currentConfig[key] != _originalConfig[key])
                {
                    Console.WriteLine($"Value for key '{key}' has changed.");
                }
            }
            else
            {
                Console.WriteLine($"Key '{key}' was removed.");
            }
        }

        foreach (var key in _currentConfig.Keys)
        {
            if (!_originalConfig.ContainsKey(key))
            {
                Console.WriteLine($"New key '{key}' added.");
            }
        }
    }
}
