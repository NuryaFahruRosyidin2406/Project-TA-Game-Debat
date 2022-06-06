EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{Name("Fatih")}
{Icon("fatih")}
{CharExpression("chitose",6)}
{ChangeTime(0)}
Namun, tampaknya hal ini tidak lagi efektif. 

{Name("Pemain")}
{Icon("pemain")}
{CharExpression("chitose",6)}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen sanggahan untuk membantah argumen lawan!)

* [Memberikan persiapan UN]
{ChangeScript("1_Argumen1_1")}

* [Membuat lingkungan sekolah bebas stress]
{ChangeScript("1_Argumen1_2")}

* [Batal Menginterupsi]
{ChangeScript("1_Argumen1_3")}