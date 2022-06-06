EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL TransNum(transNumber)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}

{Name("Moderator")}
{Icon("mc1")}
{ChangeTime(4)}
Terima kasih kepada pihak afirmasi yang telah menyampaikan argumennya.

{ChangeTime(5)}
Selanjutnya, dipersilahkan kepada pihak oposisi untuk menyampaikan argumennya.

{Name("Pemain")}
{Icon("pemain")}
{ChoiceTime(1000)}
{ChangeTime(0)}
(Pilih argumen yang ingin dipakai!)

* [Motivasi Belajar]
{ChangeScript("2_Argumen1")}

* [Mengukur Potensi]
{ChangeScript("2_Argumen2")}

* [Persiapan Seleksi Sekolah/Kuliah]
{ChangeScript("2_Argumen3")}