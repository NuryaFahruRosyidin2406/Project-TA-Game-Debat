EXTERNAL Name(charName)
EXTERNAL Icon(charName)
EXTERNAL CharAnimation(charName, animationName)
EXTERNAL CharExpression(charName, expressionInt)
EXTERNAL ChangeTime(timeLeft)
EXTERNAL ShowArgue(argueStatus)
EXTERNAL ChangeScript(scriptName)
EXTERNAL ChoiceTime(timeLeft)
EXTERNAL AddDebateScoreIsi(debateScoreIsi)
EXTERNAL AddDebateScoreStrategi(debateScoreStrategi)

{ChangeTime(0)}
Dapat saya simpulkan bahwa Ujian Nasional tidak dapat dijadikan acuan kelulusan yang efektif

{Name("Pemain")}
{Icon("pemain")}
{CharAnimation("chitose","AgreeWithYou")}
{CharExpression("chitose",0)}
{ChoiceTime(10)}
{ChangeTime(2)}
{ShowArgue(false)}
(Pilih argumen untuk membantah argumen lawan!)

* [Hasil membantu fokus pada proses]
{AddDebateScoreIsi(13)}
{AddDebateScoreStrategi(1)}
{ChangeScript("1_Argumen3_1")}

* [Hasil lebih penting daripada proses]
{AddDebateScoreIsi(10)}
{AddDebateScoreStrategi(1)}
{ChangeScript("1_Argumen3_2")}

* [(Batal Menginterupsi)]
{AddDebateScoreIsi(0)}
{AddDebateScoreStrategi(0)}
{ChangeScript("1_Argumen3_3")}