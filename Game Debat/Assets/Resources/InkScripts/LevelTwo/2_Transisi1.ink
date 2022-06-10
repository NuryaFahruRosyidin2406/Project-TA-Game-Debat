EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}
test 

{Name("Pemain")}
{Icon("pemain")}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen sanggahan untuk membantah argumen lawan!)

* [Media Sosial Melatih Interaksi Sosial]
{ChangeScript("2_Argumen1_1")}

* [Membatasi Penggunaan Media Sosial]
{ChangeScript("2_Argumen1_2")}

* [Batal Menginterupsi]
{ChangeScript("2_Argumen1_3")}