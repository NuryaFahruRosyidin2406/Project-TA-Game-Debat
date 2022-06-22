EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}
Test

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Agree")}
{ChoiceTime(1000)}
{ChangeTime(2)}
(Pilih argumen yang ingin dipakai!)

* [Menambah Kepercayaa Diri]
{ChangeScript("1_Argumen1_2")}

* [Banyak Dampak Positif]
{ChangeScript("1_Argumen1_3")}