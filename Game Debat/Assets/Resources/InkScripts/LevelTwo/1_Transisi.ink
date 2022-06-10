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
{CharAnimation("haru_greeter_t03","Listening")}
{ChoiceTime(1000)}
{ChangeTime(4)}
Pilih argumen yang ingin dipakai!

* [Meningkatkan Keterampilan]
{ChangeScript("1_Argumen1")}

* [Menambah Kepercayaan Diri]
{ChangeScript("1_Argumen2")}

* [Banyak Dampak Positif]
{ChangeScript("1_Argumen3")}