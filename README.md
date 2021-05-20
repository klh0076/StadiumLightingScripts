# StadiumLightingScripts
This contains ONLY the C# scripts that were used to control the UI components in our senior design project for Mike Moody w/ Music Matters. 



S.cs is the main frame controller
SectionFrame.cs is the controller when a user expands a sections and now has ability to control colors of individual seats
LighShow.cs is a class that is used for storage of the seat color values at a given frame and provides fucntions for setting and getting values
PixelAction.cs is a controller attached to indiviudal seats in the SectionFrame that allows a click to refrence the correct object be parsing a input string that was dynamically created fror each pixel.
