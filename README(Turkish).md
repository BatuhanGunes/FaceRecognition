**Dil :** [English](https://github.com/BatuhanGunes/FaceRecognition) / Turkish

# Face Recognition

Bu proje, önceden çekilmiş herhangi bir fotoğraf üzerinde yüz tespiti yapar. Kullanıcıya bulunan yüzü bir çerçeve ile gösterir. Aynı zamanda bulunan yüzler orjinal fotoğraftan kesilerek ayrı ayrı bir liste içerisinde gösterilir. Bu listedekilerin sayısı ile fotoğrafta bulunan kişilerin sayısı kullanıcıya gösterilir. Aynı zamanda fotoğrafta bulunan yüzlerin gözleri ve ağızlarıda kullanıcıya gösterilebilmektedir. Yüz tespiti esnasında haar cascade algoritması kullanılmıştır. Arayüz içerisinde bulunan parametreler ile arka planda çalışan algoritma düzenlenebilir. Böylece algoritma fotografa göre kolayca iyileştirilebilir.

`
Projenin oluşturulma tarihi : Ekim 2019
`

## Screenshots

<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/FaceAndEye.png"> 
<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/Face.png"> 
<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/Eye.png"> 
<img align="center" src="https://github.com/BatuhanGunes/FaceRecognition/blob/master/Screenshots/FaceTeam.png"> 

## Başlangıç

Projeyi çalıştırabilmek için proje dosyalarının bir kopyasını yerel makinenize indirin. Gerekli kütüphanelerin kurulumunu gerçekleştirin. Gerekli ortamları edindikten sonra projeyi bu ortamda açarak çalıştırabilir ve çalıştırıldıktan sonra açılan pencere üzerinden uygulamayı kullanabilirsiniz. İkinci kez çalıştırılmak istenildiğinde, projenin bulunduğu konumda ~\imageOperations\bin\Debug\imageOperations.exe dosyasını çalıştırmanız yeterli olacaktır.

### Gereklilikler

- Microsoft Visual Studio 
- OpenCV 3.4.3.18

Projeyi çalıştırabilmek için ilk olarak [Microsoft Visual Studio ](https://visualstudio.microsoft.com/) adresinden sisteminize uygun C# IDE olan Microsoft Visual Studio yazılımının herhangi bir sürümünü edinerek yerel makinenize kurmanız gerekmektedir. Bir sonraki işlem olarak OpenCv kütüphanesini sisteminize kurunuz. IDE ortamına bu kütüphaneyi tanıtınız. Daha sonra projemizi IDE ortamına tanıtıp debug işlemini gerçekleştirmeniz yeterli olacaktır. Eğer bütün işlemleri gerçekleştirdikten sonra yüz tanıma işlemi sırasında hata alıyorsanız aşağıda ismi geçen dll dosyalarını opencv kütüphanesi içerisinden ~\imageOperations\bin\Debug\ adresine kopyalamanız gerekmektedir. Kopyalanması gereken dll dosyaları;
- cufft64_75.dll
- opencv_cudaarithm310.dll
- opencv_cudafilters310.dll

## Yazarlar

* **Batuhan Güneş**  - [BatuhanGunes](https://github.com/BatuhanGunes)

Ayrıca, bu projeye katılan ve katkıda bulunanlara [contributors](https://github.com/BatuhanGunes/FaceRecognition/graphs/contributors) listesinden ulaşabilirsiniz.

## Lisans

Bu proje Apache lisansı altında lisanslanmıştır - ayrıntılar için [LICENSE.md](https://github.com/BatuhanGunes/FaceRecognition/blob/master/LICENSE) dosyasına bakabilirsiniz.

