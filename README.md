# Percentage Property Drawer for Unity

This solution includes a custom attribute `PercentageAttribute` and a property drawer `PercentDrawer` that work together to provide a convenient way of displaying float values as percentages in the Unity Editor.

![image](https://github.com/RimuruDev/Unity-PercentDrawer/assets/85500556/274123a4-415b-4b49-825c-ab7a0568262a)
![image](https://github.com/RimuruDev/Unity-PercentDrawer/assets/85500556/689774b6-279a-4a74-96f4-76a054025398)


## Installation

1. Create a folder named `Editor` within your project's `Assets` directory if it does not already exist. Unity requires that all editor scripts be located in a folder named `Editor`.
2. Create a folder named `Attributes` within your `Assets` directory to store custom attributes.
3. Place the `PercentageAttribute.cs` file inside the `Attributes` folder.
4. Place the `PercentDrawer.cs` file inside the `Editor` folder.

Your folder structure should look like this:

```text
Assets/
│
├── Editor/
│ └── PercentDrawer.cs
│
└── Attributes/
└── PercentageAttribute.cs
```

## Usage

To use the `PercentageAttribute`, you first need to define it in a script file:

```csharp
// PercentageAttribute.cs
using UnityEngine;

public class PercentageAttribute : PropertyAttribute {}
```
Then, apply the [Percentage] attribute to any float field in your MonoBehaviour or ScriptableObject classes:
```csharp
// SomeScript.cs
using UnityEngine;

public class SomeScript : MonoBehaviour
{
    [Percentage]
    public float dropChance;
}
```
When you select a GameObject with this script attached in the Unity Editor, you'll see the dropChance field displayed as a slider with a percentage value next to it.

# Customizing the Drawer
If you wish to customize the behavior of the `PercentDrawer`, you can edit the `PercentDrawer.cs` file within the `Editor` folder. Comments in the code provide guidance on what each part does and how to adjust the layout.

# Support
For support, questions, or contributions, please open an issue on the repository's issue tracker.


Contributing
Contributions to improve the `PercentageAttribute` and `PercentDrawer` are welcome. Please follow the standard pull request process to submit improvements.

# License
This project is licensed under the GNU License - see the LICENSE file for details.
