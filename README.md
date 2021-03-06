# DxR
DxR makes it easy to create <b>D</b>ata-driven graphics in <b>xR</b>, i.e., MR/VR/AR, using Microsoft's Mixed Reality ecosystem and Unity3D. You will find helpful instructions using the following links:

1. [Setup](SETUP.md)
2. [Authoring](AUTHORING.md)
3. [Development](DEVELOPMENT.md)

## Quick Guide

1. Install Unity3D editor [version 2017.2.0p1-MRTP4](http://beta.unity3d.com/download/b1565bfe4a0c/UnityDownloadAssistant.exe).
2. Import [DxR.unitypackage](https://github.com/ronellsicat/DxR/raw/master/DxR.unitypackage) into your project.
3. Open DxRExamples/template.unity.
4. If your Immersive Head-Mounted-Display (IHMD) or HoloLens is connected and setup, press play - you should see a simple DxR data visualization in your immersive environment. If no device is connected, turn off VR Support (File -> Build Settings -> Player Settings -> UWP tab -> XR Settings -> uncheck VR Supported) and press play to view scene in the editor. Detailed setup instructions can be found [here](SETUP.md).
5. To customize the visualization, edit StreamingAssets/DxRSpecs/template.json. Detailed instructions can be found [here](AUTHORING.md).
