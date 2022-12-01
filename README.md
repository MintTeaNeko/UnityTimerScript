# UnityTimerScript
Simplistic Timer Script for making timer based things like effects, spawning things, and more.

# Usage for the timer script

```csharp
using UnityEngine;

public class MyClassScript : MonoBehaviour
{
    private UnityTimerScript _timer;

    private void Start()
    {
        _timer = gameObject.AddComponent<UnityTimerScript>();
        _timer.Duration = 10f;
        _timer.OnFlagReset += OnFlagReset;
    }

    private void OnFlagReset()
    {
        Debug.Log("The flag has been reset");
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Tab) && !_timer.Running)
        {
            Debug.Log("Tab key was pressed, so starting the timer!");
            _timer.Running = true;
        }
    }
}
```
