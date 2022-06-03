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
Potensi dapat di ukur menggunakan UTS dan UAS, tidak perlu UN

{Name(". . .")}
{Icon("ray")}
{CharExpression("chitose",6)}
{ChangeTime(2)}
{ShowArgue(false)}
Pilih untuk mempertahankan argumen! 

* [UTS dan UAS Tidak Berstandar Nasional]
{ChangeScript("2_Argumen2_1")}

* [UTS dan UAS Tidak Dapat Digunakan]
{ChangeScript("2_Argumen2_2")}