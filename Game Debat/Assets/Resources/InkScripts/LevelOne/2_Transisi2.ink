EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)

{ChangeTime(0)}
Test

{Name("Player")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",1)}
{ChangeTime(4)}
Motivasi belajar bisa di dapatkan dari tempat lain. Tidak hanya di UN

{Name(". . .")}
{Icon("ray")}
{CharExpression("chitose",6)}
{ChangeTime(2)}
{ShowArgue(false)}
Pilih untuk mempertahankan argumen! 

* [UN Pemberi Motivasi Secara Nasional]
{ChangeScript("2_Argumen1_1")}

* [UN Adalah Bentuk Motivasi Terbaik]
{ChangeScript("2_Argumen1_2")}