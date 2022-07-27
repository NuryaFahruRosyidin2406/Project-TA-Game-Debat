EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL DebateStatus(debateStatus)

{ChangeTime(0)}
Test

{Name("Budi")}
{Icon("pemain")}
{CharAnimation("haru_greeter_t03","Agree")}
{ChoiceTime(1000)}
{ChangeTime(2)}
{DebateStatus(true)}
(Pilih argumen yang ingin dipakai!)

* [Meningkatkan Keterampilan]
{ChangeScript("1_Argumen1")}

* [Menambah Kepercayaan Diri]
{ChangeScript("1_Argumen2")}

* [Banyak Dampak Positif]
{ChangeScript("1_Argumen3")}