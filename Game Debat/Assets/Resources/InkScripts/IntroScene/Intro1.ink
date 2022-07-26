Kamu!

EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ChangeScene(sceneName)
EXTERNAL TutorialPass(status)

{Name("???")}
{Icon("fatih")}
{CharAnimation("chitose","WavingHand")}
{CharExpression("chitose",3)}
{ChangeTime(10)}
Hay! Ku dengar kau tertarik dengan debat bukan?

{ChangeTime(10)}
Kau datang ke tempat yang tepat.

{Name("Fatih")}
{CharAnimation("chitose","GivinganArgument")}
{CharExpression("chitose",0)}
{ChangeTime(10)}
Oh iya, kenalkan. Aku Fatih.

{ChangeTime(10)}
Aku ketua club debat di sekolah ini.

{ChangeTime(10)}
{CharExpression("chitose",1)}
Ngomong ngomong, apakah kamu familiar dengan cara debat di sini?

{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",3)}
{ChangeTime(10)}
Jika tidak, aku dengan senang hati akan mengajarimu 

* [Iya. Aku sudah paham dengan cara debat di sini.]

{Name("Budi")}
{Icon("pemain")}
{ChangeTime(10)}
Iya. Aku sudah sangat paham tentang teknik dan cara debat disini.

{Name("Fatih")}
{Icon("fatih")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",3)}
{ChangeTime(10)}
Bagus!

{CharExpression("chitose",0)}
{ChangeTime(10)}
Kalo gitu kita bisa langsung mulai

{CharAnimation("chitose","WavingHand")}
{ChangeTime(10)}
Ayo ikut aku ke ruang debat

{TutorialPass(true)}
{ChangeScene("LevelSelection")}

* [Tidak. Bisa tolong ajari aku.]

{Name("Budi")}
{Icon("pemain")}
{ChangeTime(10)}
Aku baru disini. Bisa ajari aku cara debat?

{Name("Fatih")}
{Icon("fatih")}
{ChangeTime(10)}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",3)}
Tentu saja!

{CharExpression("chitose",0)}
{ChangeTime(10)}
Ada beberapa hal yang perlu kamu ketahui. Seperti peraturan.

{ChangeTime(10)}
Peraturan di Sekolah ini adalah debat akan di pandu oleh seorang moderator.

{ChangeTime(10)}
Debat di sekolah ini dilakukan oleh dua orang dengan waktu yang terbatas.

{ChangeTime(10)}
Satu orang akan mendukung masalah yang diperdebatkan.

{ChangeTime(10)}
Satu orang lagi akan melawan permasalahan yang ada.

{ChangeTime(10)}
Di akhir debat, juri akan menilai adu argumen peserta.

{CharAnimation("chitose","AgreeWithYou")}
{ChangeTime(10)}
Jadi, kau harus memilih argumen yang tepat jika ingin mendapatkan nilai terbaik.

{ChangeTime(10)}
Untuk teknis detailnya. Ayo lihat petunjuk ini.

{ChangeScene("Tutorial")}

* [(Diam)]

{Name("Budi")}
{Icon("pemain")}
{ChangeTime(10)}
. . .

{Name("Budi")}
{Icon("pemain")}
{ChangeTime(10)}
. . . . . .

{Name("Fatih")}
{Icon("fatih")}
{ChangeTime(10)}
{CharExpression("chitose",1)}
O-okay... 

{Name("Fatih")}
{Icon("fatih")}
{ChangeTime(10)}
{CharAnimation("chitose","GivinganArgument")}
Aku anggap kau sudah paham. Kalau begitu, ayo ikut aku ke halaman sekolah.

{TutorialPass(true)}
{ChangeScene("LevelSelection")}
