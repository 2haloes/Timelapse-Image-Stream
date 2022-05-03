#TimelapseImageStream

This is a work in progress tool to create timelapses from an auto updating image stream.

Development of this is based on the FlashForge Creator 3 3D printer that uses an auto updating image stream for it's camera and the only item I currently have that outoputs this kind of stream.

This is a heavy work in progress currently, the current aims are:  
- Leave as many things to the user as possible with resonable defaults (e.g. 1 minute default for grabbing an image)
- Work with as many devices as possible (As stated above, I only have one device with this type of output)
- Allow for auto compiling the timelapse into a video
- Command line menus as well as command line options 
- Figure out some way of automatically stopping if mutliple images are the same (if the recorded item has finished, can be turned off of course)
- Progress tracking!

What I would like to do but are currently waiting until the core program is complete (if anyone would like to help with these then feel free):  
- Gather information surrounding other devices and protocols, currently I've only gotten one device that outputs .jpg files
- Run this using existing video files or streams. Once the core program is complete then this will be the focus