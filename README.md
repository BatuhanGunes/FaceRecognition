**Language :** English / [Turkish](https://github.com/BatuhanGunes/FaceRecognition/blob/master/README(Turkish).md)

# Face Recognition

This project makes face recognition in any photograph taken before. Shows the user with the face framed. At the same time, the faces found are cut from the original photo and shown in a separate list. The number of people in the photo is displayed to the user. At the same time, the eyes and mouths of the faces in the photo can be shown to the user. During facial recognition, the haar cascade algorithm was used. The algorithm that runs in the background can be edited with the parameters in the interface. Thus, the algorithm can be easily developed according to the photo.

`
Project creation date: October 2019
`

## Screenshots

<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/FaceAndEye.png"> 
<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/Face.png"> 
<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/Eye.png"> 
<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/FaceTeam.png"> 

## Getting Started

Download a copy of the project files to your local machine to run the project. Install the necessary libraries. After obtaining the required environments, you can open the project in this environment and run it and use the application through the window that opens after it is run. When trying to run a second time, simply run ~ \imageOperations \bin \Debug \imageOperations.exe in the location of the project.

### Prerequisites

- Microsoft Visual Studio 
- OpenCV 3.4.3.18

To run the project, you must first obtain any version of Microsoft Visual Studio software that has the C # IDE for your system from [Microsoft Visual Studio](https://visualstudio.microsoft.com/) and install it on your local machine. As a next step, install the OpenCv library on your system. Introduce this library to the IDE environment. Then, it will be enough to introduce our project to IDE environment and perform debug operation. If you get an error during face recognition after performing all operations, you should copy the dll files mentioned below from the opencv library to ~\imageOperations\bin\Debug\. Dll files that need to be copied;
- cufft64_75.dll
- opencv_cudaarithm310.dll
- opencv_cudafilters310.dll

## Authors

* **Batuhan Güneş**  - [BatuhanGunes](https://github.com/BatuhanGunes)

See also the list of [contributors](https://github.com/BatuhanGunes/FaceRecognition/graphs/contributors) who participated in this project.

## License

This project is licensed under the Apache License - see the [LICENSE.md](https://github.com/BatuhanGunes/FaceRecognition/blob/master/LICENSE) file for details.
