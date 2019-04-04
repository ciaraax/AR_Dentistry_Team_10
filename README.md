# Augmented Reality Dental Hospital

## Introduction

The following is a README.md for Team 10's Augmented Reality Large Group project. This project was created for Cardiff University's Dental Surgery with collaboration from the National Software Academy (Newport). The project is a functioning prototype, aiming to solve the problem that the client proposed.

## The problem definiton
The problem is that the waiting room that is shared between pediatrics and orthodontics is very small and there isn't room for everything. There is a small area for toys and books that are all for younger ages and nothing for older children and teenagers. The clients want some added features to the room via AR to make the waiting area more fun for the children waiting for their appointments. They want entertainment with a message as well as providing a distraction for the children so there are fewer disruptions in the waiting area. Even though it is a shared waiting room - the age demographics we will be aiming for is 10-year-olds. They want the room to be foremost the basis of all Augmented Reality.

## Project Description 
This project was built using Unity with Vuforia SDK. We chose Unity because it's a feature rich tool which allowed us to add various functionality to the project. We used Vuforia becasue it is one of the most popular SDKs for developing AR applications. This gave us the oppurtunity to use target images to develop an AR app. Vuforia also allowed us to use Vuforia's internal database system to manage all our traget images. Another reason we chose Unity with Vuforia was because of the wealth of online support provided by the community online. Another advantage of Vuforia is it's cross platform capabilities and it is not restricted to the latest Android OS like some of the other SDKs. 

## Design Justification
This app was designed with a child theme in mind, since we were developing for children we had to make sure we used child friendly characters and bright colours. We also had to make sure we used child friendly language therfore we used basic words and reduced text to vert short sentences. 

## Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Git will be required to clone this repository. You will need and account and git bash to run the clone command. The repository is hosted here: https://github.com/ciaraax/AR_Dentistry_Team_10

You will also need to have Unity and an android device with usb wire to run this application. You can download Unity here: https://unity3d.com/get-unity/download

### Installation and running 

Navigate to the repository on GitHub and copy the 'clone with ssh' link. Open a Git Bash prompt in a directory of your choice and execute the following command:

```

git clone https://github.com/ciaraax/AR_Dentistry_Team_10.git

```

This will clone the source code into a directory called AR_Dentistry_Team_10. 

Next, open up Unity, and click the 'open' option. This will lead to opening your directory. NAvigate to the repository you have cloned and double click. This wil then open the project in Unity. 

Connect your Android device to your computer via the USB wire, then, in Unity, click 'File' and 'Build and Run' This will then build the application and will automaticall open the application on your Android device. 

## Running the tests

Please remove the SceneManagment test from the Editor folder to the Assets folder to run in Play Mode. Move it back into the Editor folder when building the app. 

To run the play mode tests within unity you need to:

Go to Window > General > Test Runner.

Click the small drop-down menu in the top-right of the window.

Click Enable playmode tests for all assemblies.

In the dialog box appears, click OK to manually restart the Editor.

Then you can run both edit mode and play mode tests by sqtiching betwee the 'EditMode' and 'PlayMode' tabs

Then press 'Run All' in the top left corner


## Built with 
* [Unity](https://unity.com/) - Development Platform
* [Vuforia](https://www.vuforia.com/) - SDK used
* [Android Studio] (https://developer.android.com/studio)- SDK


## Contributing

Please read the CONTRIBUTION.MD for details on our code of conduct.

## Versioning

Github is being used to version control the project. Our branching policy is as follows, Where 'M' stands for merge:

```
master
|
+-- dev
|   |
|   +-- Story/Feature Branch
|   |   |
|   |   +-- Optional Branch
|   |   |   |
|   |   +-- M
|   |   |
|   +-- M
+-- M
|
```
master is a protected branch and require a review on the pull request, before the branch is merged.


## Authors

* **Ciara Langton** - *Design and Development* - [ciaraax](https://github.com/ciaraax)
* **Masroor Unar** - *Design and Development* - [Masroor-Unar](https://github.com/Masroor-Unar)
* **Ishaq Hussain** - *Design and Development* - [ishaq18](https://github.com/ishaq18)



See also the list of [contributors](https://github.com/ciaraax/AR_Dentistry_Team_10/graphs/contributors) who participated in this project.

## Acknowledgements
* Unity Docs were extremely helpful for testing -
https://docs.unity3d.com/Manual/testing-editortestsrunner.html
* This Tutorial helped in the making of the Suagr destroyed game -
https://code.tutsplus.com/tutorials/pokemon-go-style-augmented-reality-with-vuforia-part-2--cms-27232
* This Tutorial helped with the colouring app game -
https://sushanta1991.blogspot.com/2018/07/how-to-make-ar-coloring-application-in.html
* Vuforia docs were also very helpful in this project-
https://developer.vuforia.com/forum/cloud-recognition/unity-documentation
* Model for Dragon free to use fine for personal and comercial
https://free3d.com/3d-models/dragon
* Tutorial for fighter chracter fine for personal use Ambigious about comercial
https://www.ourtechart.com/augmented-reality/tutorial/augmented-reality-character-animation/
* Anime girl from unity store Copy right
https://assetstore.unity.com/packages/3d/characters/unity-chan-model-18705
* Tutorial for 2D game fine for comercial use
https://www.youtube.com/watch?v=tyAutnOlsfA
* Video used on the target image is from YouTube
https://www.youtube.com/watch?v=voZuS09kczg
* Model for Apple was free to use 
https://www.turbosquid.com/3d-models/free-food-3d-model/889330
* Model for Chocolate was free to use 
https://www.turbosquid.com/3d-models/free-3ds-mode-sweet-chocolat/591946


