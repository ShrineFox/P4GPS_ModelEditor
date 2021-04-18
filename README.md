# P4GPS_ModelEditor
Modifies values in P4G's ps_model.bin file, found in facility/cmbroot.arc.  
![](https://i.imgur.com/MCyiser.png)  
Values you can change for both Fusion and Compendium are:
- Right Offset
- Bottom Offset
- Scale
- Rotation

# How to Use
1. Extract ps_model.bin from cmbroot.arc using [Amicitia](https://github.com/TGEnigma/Amicitia/releases).  
2. Pick the ID of the Persona you want to scale/reposition/rotate ([list here](https://amicitia.miraheze.org/wiki/Persona_4_Golden/Personas))
3. Edit the values. They are automatically saved once you hit Apply or change ID.
4. Replace the original ps_model.bin in cmbroot.arc. Open the game to see changes!

# Testing In Real Time
Since it's hard to know what values to use without visual aid, you can use [CheatEngine](https://www.cheatengine.org/) to preview changes.
1. Start the game and view your Persona in the compendium.
2. Press L to view the mythology info, which will load the model.
3. Choose Open Process and pick the window P4G is running in.
4. Choose "Add Address Manually".
5. Using Windows Calculator in Programmer Mode, get the address, add the record and enable it. You should see changes immediately.  
![](https://i.imgur.com/PvrJQNv.png)  
## Finding Addresses
These change from time to time, so here's [a tutorial video](https://www.youtube.com/watch?v=H_YEB8efylQ) on finding them. Below is an example.
## Compendium Records
1. Right Offset: 4DB83630 + (your persona ID * 32) | Type: 2 Bytes | Value: -32,768 to 32,767
2. Bottom Offset: 4DB83632 + (your persona ID * 32) | Type: 2 Bytes | Value: -32,768 to 32,767
3. Scale: 4DB83638 + (your persona ID * 32) | Type: Float | Value: 0 to 2,147,483,647
4. Rotation: 4DB8363C + (your persona ID * 32) | Type: Float | Value: 0 to 2,147,483,647
## Fusion Records
1. Right Offset: 577D3EB0 + (your persona ID * 32) | Type: 2 Bytes | Value: -32,768 to 32,767
2. Bottom Offset: 577D3EB2 + (your persona ID * 32) | Type: 2 Bytes | Value: -32,768 to 32,767
3. Scale: 577D3EB8 + (your persona ID * 32) | Type: Float | Value: 0 to 2,147,483,647
4. Rotation: 577D3EBC + (your persona ID * 32) | Type: Float | Value: 0 to 2,147,483,647
