# Augmented Reality Dental Hospital

## Introduction

The following is a README.md for Team 10's Augmented Reality Large Group project. This project was created for Cardiff University's Dental Surgery with collaboration from the National Software Academy (Newport). The project is a functioning prototype, aiming to solve the problem that the client proposed.

There is a small, shared waiting room between paediatrics and orthodontics, as well as their parent(s). As physically making the space isn't feesible, they wanted to use technology to keep the children entertained and either kept in their seats or in one aspect of the waiting room, to make the waiting room a more enjoyable place for both younger children and make it quiter for the older patients. 

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

## Design justification
The design of the colourful naviagtion was to be chid friendly and keep the app upbeat. 

## Built with 
* [Unity](https://unity.com/) - Development Platform
* [Vuforia](https://www.vuforia.com/) - SDK used


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



See also the list of [contributors](https://github.com/your/project/contributors) who participated in this project.

## Acknowledgements
* Unity Docs were extremely helpful for testing -
https://docs.unity3d.com/Manual/testing-editortestsrunner.html
* This Tutorial helped in the making of the Suagr destroyed game -
https://code.tutsplus.com/tutorials/pokemon-go-style-augmented-reality-with-vuforia-part-2--cms-27232
* This Tutorial helped with the colouring app game -
https://sushanta1991.blogspot.com/2018/07/how-to-make-ar-coloring-application-in.html
* Vuforia docs were also very helpful in this project-
https://developer.vuforia.com/forum/cloud-recognition/unity-documentation

