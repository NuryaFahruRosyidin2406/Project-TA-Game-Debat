EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}
Test

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChoiceTime(1000)}
{ChangeTime(4)}
Pilih argumen yang ingin dipakai!

* [Motivasi Belajar]
{ChangeScript("2_Argumen3_1")}

* [Mengukur Potensi]
{ChangeScript("2_Argumen3_2")}