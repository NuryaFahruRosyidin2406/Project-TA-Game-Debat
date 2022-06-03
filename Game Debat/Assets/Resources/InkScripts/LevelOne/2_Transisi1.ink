EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)

{ChangeTime(0)}
Test

{Name(". . .")}
{Icon("ray")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChangeTime(4)}
{ShowArgue(false)}
Pilih argumen yang ingin dipakai!

* [Motivasi Belajar]
{ChangeScript("2_Argumen1")}

* [Mengukur Potensi]
{ChangeScript("2_Argumen2")}

* [Persiapan Seleksi Sekolah/Kuliah]
{ChangeScript("2_Argumen3")}