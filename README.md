
# Character Movement in Unity2D - English

With this repository, you can learn "How to Move Characters" in Unity 2D.


## Frequently asked Questions

#### What are variables for?

Rigidbody2D rb; - for our character's physical activies.

float xmovement; - For horizontal movement of our character.

public int xspeed; - For the horizontal speed of our character.

public int jumpForce; - For our character's jumping power.

public bool onFloor; - For check that our character is on the ground.

public bool faceRight = True; - For control the direction our character is facing.

#### What is meaning Rigidbody2D?

It uses the Unity physics engine to simulate physical movements as in the real world.You have to add Rigidbody2D(component) to your character.

"rb = GetComponent<Rigidbody2D>();" - With this, we connect the rb variable we created to the rigidbody2D in Unity.

#### What is meaning OnCollisionEnter2D?

It is a function that works by sending a message when an object touches another object.


ATTENTİON:For the character's jump function to work correctly, you need to make the tag of your floor "floor" in unity.
## Author

- [Efe Baydoğan](https://www.instagram.com/efebaydogan10) for design and development.

  ----------------------------------------------------------------------------------------------------

  # Unity2D'de Karakter Hareketi - Türkçe

Bu depo ile Unity 2D'de "Karakterler Nasıl Hareket Ettirilir" öğrenebilirsiniz.


## Sıkça Sorulan Sorular

#### Değişkenler ne içindir?

Rigidbody2D rb; - Karakterimizin Fiziksel Aktiviteleri için.

float xmovement; - Karakterimizin yatay hareketi için.

public int xspeed; - Karakterimizin yatay hızı için.

public int jumpForce; - Karakterimizin zıplama gücü için.

public bool onFloor; - Karakterimizin yerde olup olmadığını kontrol etmek için.

public bool faceRight = True; - Karakterimizin baktığı yönü kontrol etmek için.

#### Rigidbody2D ne anlama gelir?

Gerçek dünyadaki gibi fiziksel hareketleri simüle etmek için Unity fizik motorunu kullanır. karakterinize Rigidbody2D (bileşen) eklemeniz gerekir.

"rb = GetComponent<Rigidbody2D>();" - Bununla oluşturduğumuz rb değişkenini Unity'deki rigidbody2D'ye bağlıyoruz.

#### OnCollisionEnter2D ne anlama geliyor?

Bir nesne başka bir nesneye dokunduğunda mesaj göndererek çalışan bir fonksiyondur.

DİKKAT:Karakterin zıplama fonksiyonunun doğru çalışması için, zemininizin etiketini unity'de "floor" yapmanız gerekir.
## Yazar

- [Efe Baydoğan](https://www.instagram.com/efebaydogan_) tasarım ve kodlama için.
