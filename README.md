
## Troubleshooting

### XR Toolkit

If XRController script does not have the default actions connected. Go to the preset slider at the top right of the component inspector. 


## Roadmap


Mode based setup for the following

### Create physics based effectors

- Hand interactors, one collider per knuckle, grouped by finger
- Hand interactors, one collider per finger tip
- Controller interactors with simplified two finger hand 
- 

### Determine priority and inhibition strategies

- Triggering note should happen per group 

### Advanced physics monitoring and descriptors

### XR Toolkit integration

https://docs.unity3d.com/Packages/com.unity.xr.interaction.toolkit@2.0/manual/extending-xri.html

Interactors and Interactables both have various event callbacks that can be used to drive reactions to interaction state changes. Experiment with both Interactor and  Interactable centered note control.

## Quest 

### Build Settings

https://developer.oculus.com/documentation/unity/unity-conf-settings/
https://developer.oculus.com/documentation/unity/unity-build/


### Supported XR Plugins

https://docs.unity3d.com/Packages/com.unity.xr.openxr@1.9/manual/features/metaquest.html

### Hand tracking

Got it to work with V2, then needs to be enabled on the device OS (should ask automatically if it is specified in the settings)

https://developer.oculus.com/documentation/unity/unity-isdk-getting-started/#set-up-hands

Got it working with link by activating passthrough to allow hand tracking with link (in settings Beta section of the Oculus app)

https://www.reddit.com/r/oculus/comments/ewj8mn/hand_tracking_while_using_link/
https://imgur.com/8DMRu0r

Now that the passthrough beta is activated on the occulus app, generic xr interaction toolkit and xr hands demos run on windows/link from the editor 

### Developer Tooling

https://developer.oculus.com/downloads/package/oculus-developer-hub-win