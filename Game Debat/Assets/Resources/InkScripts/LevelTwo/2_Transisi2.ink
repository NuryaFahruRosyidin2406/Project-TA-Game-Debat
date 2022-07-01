EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL ChangeChoiceTime(changeTime)

{ChangeTime(0)}
test 

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Listening")}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen sanggahan untuk membantah argumen lawan!)

* [Membatasi Waktu Penggunaan Media Sosial]
{ChangeChoiceTime(-2)}
{ChangeScript("2_Argumen2_1")}

* [Memberikan Contoh Penggunaan Media Sosial]
{ChangeChoiceTime(2)}
{ChangeScript("2_Argumen2_2")}

* [(Batal Menginterupsi)]
{ChangeScript("2_Argumen2_3")}