EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)

{ChangeTime(0)}
Dapat saya simpulkan bahwa Ujian Nasional tidak dapat dijadikan acuan kelulusan yang efektif

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChoiceTime(10)}
{ChangeTime(4)}
{ShowArgue(false)}
(Pilih argumen untuk membantah argumen lawan!)

* [Hasil membantu fokus pada proses]
{ChangeScript("1_Argumen3_1")}

* [Hasil lebih penting daripada proses]
{ChangeScript("1_Argumen3_2")}