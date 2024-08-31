<p align="center"><h1>⭐Percentage Property Drawer for Unity⭐</h1></p>
 <p align="center">
  <a>
    <img alt="Made With Unity" src="https://img.shields.io/badge/made%20with-Unity-57b9d3.svg?logo=Unity">
  </a>
  <a>
  <img alt="License" src="https://img.shields.io/github/license/RimuruDev/Unity-PercentDrawer?logo=github">
  </a>
  <a>
    <img alt="Last Commit" src="https://img.shields.io/github/last-commit/RimuruDev/Unity-PercentDrawer?logo=Mapbox&color=orange">
  </a>
  <a>
    <img alt="Repo Size" src="https://img.shields.io/github/repo-size/RimuruDev/Unity-PercentDrawer?logo=VirtualBox">
  </a>
  <a>
    <img alt="Downloads" src="https://img.shields.io/github/downloads/RimuruDev/Unity-PercentDrawer/total?color=brightgreen">
  </a>
  <a>
    <img alt="Last Release" src="https://img.shields.io/github/v/release/RimuruDev/Unity-PercentDrawer?include_prereleases&logo=Dropbox&color=yellow">
  </a>
  <a>
    <img alt="GitHub stars" src="https://img.shields.io/github/stars/RimuruDev/Unity-PercentDrawer?branch=main&label=Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="GitHub user stars" src="https://img.shields.io/github/stars/RimuruDev?affiliations=OWNER&branch=main&label=User%20Stars&logo=GitHub&logoColor=ffffff&labelColor=282828&color=informational&style=flat">
  </a>
  <a>
    <img alt="" src="https://img.shields.io/github/watchers/RimuruDev/Unity-PercentDrawer?style=flat">
  </a>
</p>


This solution includes a custom attribute `PercentageAttribute` and a property drawer `PercentDrawer` that work together
to provide a convenient way of displaying float values as percentages in the Unity Editor.

![image](https://github.com/RimuruDev/Unity-PercentDrawer/assets/85500556/274123a4-415b-4b49-825c-ab7a0568262a)
![image](https://github.com/RimuruDev/Unity-PercentDrawer/assets/85500556/689774b6-279a-4a74-96f4-76a054025398)

### Option 1: Install via Unity Package Manager

1. Open Unity and go to `Window` > `Package Manager`.
2. Click the `+` button in the top left corner.
3. Select `Add package from git URL...`.
4. Enter the following URL:   ``` https://github.com/RimuruDev/Unity-PercentDrawer.git ```
5. Click `Add` to install the package.

### Option 2: Install from Releases

1. Go to the [Releases](https://github.com/RimuruDev/Unity-PercentDrawer/releases) page in this repository.
2. Download the latest `.unitypackage` file.
3. In Unity, go to `Assets` > `Import Package` > `Custom Package...`.
4. Select the downloaded `.unitypackage` file and import it into your project.

### Option 3: Install from copy-past

1. Create a folder named `Editor` within your project's `Assets` directory if it does not already exist. Unity requires
   that all editor scripts be located in a folder named `Editor`.
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

When you select a GameObject with this script attached in the Unity Editor, you'll see the dropChance field displayed as
a slider with a percentage value next to it.

# Customizing the Drawer

If you wish to customize the behavior of the `PercentDrawer`, you can edit the `PercentDrawer.cs` file within
the `Editor` folder. Comments in the code provide guidance on what each part does and how to adjust the layout.

# Support

For support, questions, or contributions, please open an issue on the repository's issue tracker.

Contributing
Contributions to improve the `PercentageAttribute` and `PercentDrawer` are welcome. Please follow the standard pull
request process to submit improvements.

# License

This project is licensed under the GNU License - see the LICENSE file for details.

Made by RimuruDev
