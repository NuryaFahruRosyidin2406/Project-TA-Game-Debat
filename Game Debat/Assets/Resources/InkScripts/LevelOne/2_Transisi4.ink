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
Persiapan Ujian Masuk Sekolah Baru Bisa Dilakukan Tanpa UN

{Name(". . .")}
{Icon("ray")}
{CharExpression("chitose",6)}
{ChangeTime(2)}
{ShowArgue(false)}
Pilih untuk mempertahankan argumen! 

* [UN Sebagai Sarana Persiapan]
{ChangeScript("2_Argumen3_1")}

* [UN Adalah Syarat Wajib]
{ChangeScript("2_Argumen3_2")}